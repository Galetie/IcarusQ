// Name: Jarryd Hassall
// Date: 29/03/2023
// SID:  30063186

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Enum for the service type
enum ServiceType
{
    None,
    Regular,
    Express
}

namespace IcarusQ
{
    public partial class IcarusQ : Form
    {
        // Time will gradually update the status strip colour until default
        static Timer statusStripUpdater = new Timer();

        // Data structures
        // 6.2	Create a global List<T> of type Drone called “FinishedList”. 
        // 6.3	Create a global Queue<T> of type Drone called “RegularService”.
        // 6.4	Create a global Queue<T> of type Drone called “ExpressService”.
        List<Drone> FinishedList = new List<Drone>();
        Queue<Drone> RegularService = new Queue<Drone>();
        Queue<Drone> ExpressService = new Queue<Drone>();

        public IcarusQ()
        {
            InitializeComponent();
            InitializeListViews();

            // Configure timer
            statusStripUpdater.Tick += statusStripColourFade;
            statusStripUpdater.Interval = 5;
        }

        #region Status Strip
        private void statusStripColourFade(object sender, EventArgs e)
        {
            // By how much to fade the current colour
            const int reductionFactor = 3;

            // Get the current colour of the status strip
            Color current = statusStrip.BackColor;

            // If the alpha is not 0, update it
            if (current.A > reductionFactor)
            {
                // Casually fade out the colour
                statusStrip.BackColor = Color.FromArgb(current.A - reductionFactor, current.R, current.G, current.B);
            }
            else
            {
                // Once it is 0, stop the timer and set the colour to completely transparent
                statusStrip.BackColor = Color.FromArgb(0, 0, 0, 0);
                statusStripUpdater.Stop();
            }
        }

        private void UpdateStatus(string status, Color colour)
        {
            tsLabel.Text = status;
            statusStrip.BackColor = colour;

            // Colour updated, start the fade effect
            statusStripUpdater.Start();
        }
        #endregion

        #region Input Getters | Setters
        #region getters
        private string GetClientName()
        {
            return tbName.Text;
        }

        private string GetDroneModel()
        {
            return tbModel.Text;
        }

        private string GetServiceProblem()
        {
            return tbServiceProblem.Text;
        }

        private double GetServiceCost()
        {
            double cost;
            if (double.TryParse(tbCost.Text, out cost))
            {
                return cost;
            }

            return -1.0;
        }

        private string GetServiceTag()
        {
            return nServiceTag.Text;
        }
        #endregion
        #region setters
        private void SetClientName(string newText)
        {
            tbName.Text = newText;
        }

        private void SetDroneModel(string newText)
        {
            tbModel.Text = newText;
        }

        private void SetServiceProblem(string newText)
        {
            tbServiceProblem.Text = newText;
        }

        private void SetServiceCost(string newText)
        {
            tbCost.Text = newText;
        }

        private void SetServiceTag(string newText)
        {
            nServiceTag.Text = newText;
        }

        private void SetServiceType(ServiceType newType)
        {
            switch (newType)
            {
                case ServiceType.None:
                    {
                        rbtnExpress.Checked = false;
                        rbtnRegular.Checked = false;
                        break;
                    }

                case ServiceType.Regular:
                    {
                        rbtnRegular.Checked = true;
                        break;
                    }

                case ServiceType.Express:
                    {
                        rbtnExpress.Checked = true;
                        break;
                    }
            }
        }
        #endregion

        // 6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        // This method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private ServiceType GetServicePriority()
        {
            if (rbtnExpress.Checked)
            {
                return ServiceType.Express;
            }
            else if (rbtnRegular.Checked) {
                return ServiceType.Regular;
            }

            return ServiceType.None;
        }
        #endregion

        private void InitializeListViews()
        {
            // Values to create the headers with
            string[] columnValues = { "Client Name", "Drone Model", "Problem Description", "Service Cost", "Service Tag" };
            ListView[] lvs = { lvRegular, lvExpress, lvFinished };

            foreach (var listview in lvs)
            {
                // Clear the headers just in case
                listview.Columns.Clear();

                // Add columns
                foreach (var value in columnValues)
                {
                    // Create the column header
                    ColumnHeader newHeader = new ColumnHeader();
                    newHeader.Text = value;
                    newHeader.Width = listview.Width / columnValues.Length;

                    // Add it to the list
                    listview.Columns.Add(newHeader);
                }
            }
        }

        // 6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void ClearFields()
        {
            // Simply call each setter and use the null value
            SetClientName(null);
            SetDroneModel(null);
            SetServiceProblem(null);
            SetServiceCost(null);
            SetServiceType(ServiceType.None);
        }

        private void DisplayDroneInfo(string clientName, string serviceProblem)
        {
            // Clear the fields for cleanliness
            ClearFields();

            // Set values
            SetClientName(clientName);
            SetServiceProblem(serviceProblem);
        }

        // 6.8	Create a custom method that will display all the elements in the RegularService queue.
        // The display must use a List View and with appropriate column headers.
        // 6.9	Create a custom method that will display all the elements in the ExpressService queue.
        // The display must use a List View and with appropriate column headers.
        private void UpdateListView(ListView lv, IEnumerable<Drone> items)
        {
            // Clear the list view
            lv.Items.Clear();

            // Add items to the display
            foreach (var drone in items)
            {
                // Create the item
                ListViewItem item = new ListViewItem(drone.getClientName());
                item.SubItems.Add(drone.getDroneModel());
                item.SubItems.Add(drone.getServiceProblem());
                item.SubItems.Add(drone.getCostString());
                item.SubItems.Add(drone.getServiceTag());

                // Add it to the list
                lv.Items.Add(item);
            }
        }

        // 6.11	Create a custom method to increment the service tag control, this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void IncrementTag()
        {
            nServiceTag.Value += nServiceTag.Increment;
        }

        // 6.5	Create a button method called “AddNewItem” that will add a new service
        // item to a Queue<> based on the priority. Use TextBoxes for the Client Name,
        // Drone Model, Service Problem and Service Cost. Use a numeric up/down control
        // for the Service Tag. The new service item will be added to the appropriate
        // Queue based on the Priority radio button.
        private void AddNewItem(object sender, MouseEventArgs e)
        {
            // Get input
            string cName = GetClientName();
            string dModel = GetDroneModel();
            string problem = GetServiceProblem();
            double cost = GetServiceCost();
            string sTag = GetServiceTag();
            ServiceType sType = GetServicePriority();

            // Validate input
            if (
                string.IsNullOrEmpty(cName) ||
                string.IsNullOrEmpty(dModel) ||
                string.IsNullOrEmpty(problem) ||
                string.IsNullOrEmpty(sTag) ||
                cost < 0 ||
                sType == ServiceType.None
                )
            {
                // Return on bad input, do not process
                UpdateStatus("Invalid Input!", Color.Red);
                return;
            }

            // Switch behaviour based on service type
            switch (sType)
            {
                case ServiceType.Regular:
                    {
                        // Add to the regular queue
                        RegularService.Enqueue(new Drone(cName, dModel, problem, cost, sTag));
                        UpdateStatus("Added new service to Regular Queue.", Color.Green);
                        UpdateListView(lvRegular, RegularService);
                        break;
                    }

                case ServiceType.Express:
                    {
                        // Add to the express queue
                        ExpressService.Enqueue(new Drone(cName, dModel, problem, cost * 1.15, sTag));
                        UpdateStatus("Added new service to Regular Queue.", Color.Green);
                        UpdateListView(lvExpress, ExpressService);
                        break;
                    }
            }

            // Notify and clear
            ClearFields();
            IncrementTag();
        }

        // 6.10	Create a custom keypress method to ensure the Service Cost textbox can only accept a double value with one decimal point.
        private void tbCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Get the char
            char input = e.KeyChar;

            // Check if number or '.'
            if (input == '.')
            {
                // If already contains, don't add another
                // Don't add if length is 0, prevent .5
                if (tbCost.Text.Length == 0 || tbCost.Text.Contains("."))
                {
                    e.Handled = true;
                    UpdateStatus("Cannot put '.' here", Color.Orange);
                }
            } else if (!char.IsNumber(input) && input != (char)Keys.Back)
            {
                e.Handled = true;
                UpdateStatus("Cannot put that here", Color.Orange);
            }
        }

        // 6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        // 6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void LVSelectedIndexChanged(object sender, EventArgs e)
        {
            // Cast the sender object to a ListView
            try
            {
                ListView lv = sender as ListView;

                // If something is selected, get the item and populate the appropriate boxes
                if (lv.SelectedIndices.Count > 0)
                {
                    ListViewItem item = lv.Items[lv.SelectedIndices[0]];
                    DisplayDroneInfo(item.SubItems[0].Text, item.SubItems[2].Text);
                }
            } catch
            {
                // If the cast fails, program has been implemented improperly
                UpdateStatus("Internal logic error, contact system administrator", Color.Black);
            }
        }

        // 6.14	Create a button click method that will remove a service item from the regular ListView
        // and dequeue the regular service Queue<T> data structure. The dequeued item must be added to
        // the List<T> and displayed in the ListBox for finished service items.
        private void btnServiceCompleteRegular_Click(object sender, EventArgs e)
        {
            // Check if there is anything to dequeue
            if (RegularService.Count != 0)
            {
                Drone dequeued = RegularService.Dequeue();
                FinishedList.Add(dequeued);
                UpdateStatus("Item marked as completed.", Color.Green);

                // Update the regular view list and completed view list
                UpdateListView(lvRegular, RegularService);
                UpdateListView(lvFinished, FinishedList);
            } else
            {
                UpdateStatus("There are no services in the regular queue to complete.", Color.Orange);
            }
        }

        // 6.15	Create a button click method that will remove a service item from the express ListView and
        // dequeue the express service Queue<T> data structure. The dequeued item must be added to the List<T>
        // and displayed in the ListBox for finished service items.
        private void btnServiceCompleteExpress_Click(object sender, EventArgs e)
        {
            // Check if there is anything to dequeue
            if (ExpressService.Count != 0)
            {
                // Dequeue and update finished
                Drone dequeued = ExpressService.Dequeue();
                FinishedList.Add(dequeued);
                UpdateStatus("Item marked as completed.", Color.Green);

                // Update the regular view list and completed view list
                UpdateListView(lvExpress, ExpressService);
                UpdateListView(lvFinished, FinishedList);
            }
            else
            {
                UpdateStatus("There are no services in the express queue to complete.", Color.Orange);
            }
        }

        // 6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void lvFinished_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Do some fancy stuff to get the double clicked item (Hittest)
            var hitTest = lvFinished.HitTest(e.X, e.Y);
            var clickedItem = lvFinished.HitTest(e.X, e.Y).Item;

            // If an item was clicked, remove it by index
            if (clickedItem != null)
            {
                FinishedList.RemoveAt(clickedItem.Index);
                UpdateListView(lvFinished, FinishedList);
            }
        }
    }
}
