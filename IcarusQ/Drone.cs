// Name: Jarryd Hassall
// Date: 29/03/2023
// SID:  30063186

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 6.1	Create a separate class file to hold the data items of the Drone.
// Use separate getter and setter methods, ensure the attributes are private
// and the accessor methods are public. Add a display method that returns
// a string for Client Name and Service Cost. Add suitable code to the Client
// Name and Service Problem accessor methods so the data is formatted as Title
// case or Sentence case. Save the class as “Drone.cs”.


namespace IcarusQ
{
    internal class Drone : IComparable<Drone>
    {
        // Store info here
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private string serviceTag;
        private double serviceCost;

        public Drone()
        { }

        // Constructors
        public Drone(string newName, string newModel, string newProblem, double newCost, string newTag)
        {
            setClientName(newName); setDroneModel(newModel); setServiceProblem(newProblem);
            setServiceTag(newTag);
            serviceCost = newCost;
        }

        private string makeTitleCase(string str)
        {
            StringBuilder sb = new StringBuilder();

            bool upper = true;
            foreach (var ch in str)
            {
                if (upper && char.IsLetter(ch))
                {
                    sb.Append(char.ToUpper(ch));
                    upper = false;
                } else
                {
                    if (ch == ' ')
                    {
                        upper = true;
                    }
                    sb.Append(char.ToLower(ch));
                }
            }

            return sb.ToString();
        }

        // Getters
        public string getClientName() { return clientName; }
        public string getDroneModel() { return droneModel; }
        public string getServiceProblem() { return serviceProblem; }
        public double getServiceCost() { return serviceCost; }
        public string getServiceTag() { return serviceTag; }

        public string getCostString()
        {
            return string.Format("${0:0.00}", serviceCost);
        }
         
        // Setters
        public void setClientName(string newName) { clientName = makeTitleCase(newName); }
        public void setDroneModel(string newModel) { droneModel = newModel; }
        public void setServiceProblem(string newProblem) { serviceProblem = makeTitleCase(newProblem); }
        public void setServiceCost(int newCost) { serviceCost = newCost; }
        public void setServiceTag(string newTag) { serviceTag = newTag; }

        public int CompareTo(Drone other)
        {
            return getClientName().CompareTo(other.getClientName());
        }
    }
}
