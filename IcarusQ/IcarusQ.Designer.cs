namespace IcarusQ
{
    partial class IcarusQ
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvRegular = new System.Windows.Forms.ListView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnServiceCompleteRegular = new System.Windows.Forms.Button();
            this.btnServiceCompleteExpress = new System.Windows.Forms.Button();
            this.lvExpress = new System.Windows.Forms.ListView();
            this.lvFinished = new System.Windows.Forms.ListView();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.groupServiceType = new System.Windows.Forms.GroupBox();
            this.rbtnExpress = new System.Windows.Forms.RadioButton();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nServiceTag = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tbServiceProblem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tcServices = new System.Windows.Forms.TabControl();
            this.tabPageRegularService = new System.Windows.Forms.TabPage();
            this.tabPageExpressService = new System.Windows.Forms.TabPage();
            this.tabPageCompleted = new System.Windows.Forms.TabPage();
            this.statusStrip.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupServiceType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nServiceTag)).BeginInit();
            this.tcServices.SuspendLayout();
            this.tabPageRegularService.SuspendLayout();
            this.tabPageExpressService.SuspendLayout();
            this.tabPageCompleted.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRegular
            // 
            this.lvRegular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRegular.HideSelection = false;
            this.lvRegular.Location = new System.Drawing.Point(6, 6);
            this.lvRegular.MultiSelect = false;
            this.lvRegular.Name = "lvRegular";
            this.lvRegular.Size = new System.Drawing.Size(437, 350);
            this.lvRegular.TabIndex = 0;
            this.lvRegular.UseCompatibleStateImageBehavior = false;
            this.lvRegular.View = System.Windows.Forms.View.Details;
            this.lvRegular.SelectedIndexChanged += new System.EventHandler(this.LVSelectedIndexChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(714, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsLabel
            // 
            this.tsLabel.BackColor = System.Drawing.Color.Transparent;
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnServiceCompleteRegular
            // 
            this.btnServiceCompleteRegular.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnServiceCompleteRegular.Location = new System.Drawing.Point(6, 362);
            this.btnServiceCompleteRegular.Name = "btnServiceCompleteRegular";
            this.btnServiceCompleteRegular.Size = new System.Drawing.Size(132, 23);
            this.btnServiceCompleteRegular.TabIndex = 2;
            this.btnServiceCompleteRegular.Text = "Service Complete";
            this.btnServiceCompleteRegular.UseVisualStyleBackColor = true;
            this.btnServiceCompleteRegular.Click += new System.EventHandler(this.btnServiceCompleteRegular_Click);
            // 
            // btnServiceCompleteExpress
            // 
            this.btnServiceCompleteExpress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnServiceCompleteExpress.Location = new System.Drawing.Point(6, 362);
            this.btnServiceCompleteExpress.Name = "btnServiceCompleteExpress";
            this.btnServiceCompleteExpress.Size = new System.Drawing.Size(132, 23);
            this.btnServiceCompleteExpress.TabIndex = 5;
            this.btnServiceCompleteExpress.Text = "Service Complete";
            this.btnServiceCompleteExpress.UseVisualStyleBackColor = true;
            this.btnServiceCompleteExpress.Click += new System.EventHandler(this.btnServiceCompleteExpress_Click);
            // 
            // lvExpress
            // 
            this.lvExpress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvExpress.HideSelection = false;
            this.lvExpress.Location = new System.Drawing.Point(6, 6);
            this.lvExpress.Name = "lvExpress";
            this.lvExpress.Size = new System.Drawing.Size(437, 350);
            this.lvExpress.TabIndex = 3;
            this.lvExpress.UseCompatibleStateImageBehavior = false;
            this.lvExpress.View = System.Windows.Forms.View.Details;
            this.lvExpress.SelectedIndexChanged += new System.EventHandler(this.LVSelectedIndexChanged);
            // 
            // lvFinished
            // 
            this.lvFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFinished.HideSelection = false;
            this.lvFinished.Location = new System.Drawing.Point(6, 6);
            this.lvFinished.Name = "lvFinished";
            this.lvFinished.Size = new System.Drawing.Size(437, 375);
            this.lvFinished.TabIndex = 6;
            this.lvFinished.UseCompatibleStateImageBehavior = false;
            this.lvFinished.View = System.Windows.Forms.View.Details;
            this.lvFinished.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFinished_MouseDoubleClick);
            // 
            // tbName
            // 
            this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbName.Location = new System.Drawing.Point(4, 31);
            this.tbName.MaximumSize = new System.Drawing.Size(500, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(223, 20);
            this.tbName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddService);
            this.groupBox2.Controls.Add(this.groupServiceType);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbCost);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.nServiceTag);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbServiceProblem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbModel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 413);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Service Details";
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(5, 381);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(223, 26);
            this.btnAddService.TabIndex = 21;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddNewItem);
            // 
            // groupServiceType
            // 
            this.groupServiceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupServiceType.Controls.Add(this.rbtnExpress);
            this.groupServiceType.Controls.Add(this.rbtnRegular);
            this.groupServiceType.Location = new System.Drawing.Point(6, 335);
            this.groupServiceType.Name = "groupServiceType";
            this.groupServiceType.Size = new System.Drawing.Size(221, 40);
            this.groupServiceType.TabIndex = 12;
            this.groupServiceType.TabStop = false;
            this.groupServiceType.Text = "Service Type";
            // 
            // rbtnExpress
            // 
            this.rbtnExpress.AutoSize = true;
            this.rbtnExpress.Location = new System.Drawing.Point(122, 15);
            this.rbtnExpress.Name = "rbtnExpress";
            this.rbtnExpress.Size = new System.Drawing.Size(62, 17);
            this.rbtnExpress.TabIndex = 13;
            this.rbtnExpress.TabStop = true;
            this.rbtnExpress.Text = "Express";
            this.rbtnExpress.UseVisualStyleBackColor = true;
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Location = new System.Drawing.Point(31, 15);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(62, 17);
            this.rbtnRegular.TabIndex = 12;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Regular";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Service Cost";
            // 
            // tbCost
            // 
            this.tbCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCost.Location = new System.Drawing.Point(5, 309);
            this.tbCost.MaximumSize = new System.Drawing.Size(500, 4);
            this.tbCost.Name = "tbCost";
            this.tbCost.ShortcutsEnabled = false;
            this.tbCost.Size = new System.Drawing.Size(87, 20);
            this.tbCost.TabIndex = 19;
            this.tbCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCost_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Service Tag";
            // 
            // nServiceTag
            // 
            this.nServiceTag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nServiceTag.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nServiceTag.Location = new System.Drawing.Point(98, 309);
            this.nServiceTag.Maximum = new decimal(new int[] {
            900,
            0,
            0,
            0});
            this.nServiceTag.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nServiceTag.Name = "nServiceTag";
            this.nServiceTag.ReadOnly = true;
            this.nServiceTag.Size = new System.Drawing.Size(130, 20);
            this.nServiceTag.TabIndex = 17;
            this.nServiceTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Service Problem";
            // 
            // tbServiceProblem
            // 
            this.tbServiceProblem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbServiceProblem.Location = new System.Drawing.Point(4, 107);
            this.tbServiceProblem.MaximumSize = new System.Drawing.Size(500, 200);
            this.tbServiceProblem.Multiline = true;
            this.tbServiceProblem.Name = "tbServiceProblem";
            this.tbServiceProblem.Size = new System.Drawing.Size(223, 177);
            this.tbServiceProblem.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Drone Model";
            // 
            // tbModel
            // 
            this.tbModel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbModel.Location = new System.Drawing.Point(4, 69);
            this.tbModel.MaximumSize = new System.Drawing.Size(500, 4);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(223, 20);
            this.tbModel.TabIndex = 11;
            // 
            // tcServices
            // 
            this.tcServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcServices.Controls.Add(this.tabPageRegularService);
            this.tcServices.Controls.Add(this.tabPageExpressService);
            this.tcServices.Controls.Add(this.tabPageCompleted);
            this.tcServices.Location = new System.Drawing.Point(251, 12);
            this.tcServices.Name = "tcServices";
            this.tcServices.SelectedIndex = 0;
            this.tcServices.Size = new System.Drawing.Size(457, 414);
            this.tcServices.TabIndex = 9;
            // 
            // tabPageRegularService
            // 
            this.tabPageRegularService.Controls.Add(this.lvRegular);
            this.tabPageRegularService.Controls.Add(this.btnServiceCompleteRegular);
            this.tabPageRegularService.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegularService.Name = "tabPageRegularService";
            this.tabPageRegularService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegularService.Size = new System.Drawing.Size(449, 388);
            this.tabPageRegularService.TabIndex = 0;
            this.tabPageRegularService.Text = "Regular Service";
            this.tabPageRegularService.UseVisualStyleBackColor = true;
            // 
            // tabPageExpressService
            // 
            this.tabPageExpressService.Controls.Add(this.btnServiceCompleteExpress);
            this.tabPageExpressService.Controls.Add(this.lvExpress);
            this.tabPageExpressService.Location = new System.Drawing.Point(4, 22);
            this.tabPageExpressService.Name = "tabPageExpressService";
            this.tabPageExpressService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpressService.Size = new System.Drawing.Size(449, 388);
            this.tabPageExpressService.TabIndex = 1;
            this.tabPageExpressService.Text = "Express Service";
            this.tabPageExpressService.UseVisualStyleBackColor = true;
            // 
            // tabPageCompleted
            // 
            this.tabPageCompleted.Controls.Add(this.lvFinished);
            this.tabPageCompleted.Location = new System.Drawing.Point(4, 22);
            this.tabPageCompleted.Name = "tabPageCompleted";
            this.tabPageCompleted.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompleted.Size = new System.Drawing.Size(449, 388);
            this.tabPageCompleted.TabIndex = 2;
            this.tabPageCompleted.Text = "Completed Services";
            this.tabPageCompleted.UseVisualStyleBackColor = true;
            // 
            // IcarusQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 451);
            this.Controls.Add(this.tcServices);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip);
            this.MaximumSize = new System.Drawing.Size(730, 1000);
            this.MinimumSize = new System.Drawing.Size(730, 490);
            this.Name = "IcarusQ";
            this.Text = "IcarusQ";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupServiceType.ResumeLayout(false);
            this.groupServiceType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nServiceTag)).EndInit();
            this.tcServices.ResumeLayout(false);
            this.tabPageRegularService.ResumeLayout(false);
            this.tabPageExpressService.ResumeLayout(false);
            this.tabPageCompleted.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRegular;
        private System.Windows.Forms.ListView lvFinished;
        private System.Windows.Forms.Button btnServiceCompleteExpress;
        private System.Windows.Forms.ListView lvExpress;
        private System.Windows.Forms.Button btnServiceCompleteRegular;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupServiceType;
        private System.Windows.Forms.RadioButton rbtnExpress;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nServiceTag;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbServiceProblem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.TabControl tcServices;
        private System.Windows.Forms.TabPage tabPageRegularService;
        private System.Windows.Forms.TabPage tabPageExpressService;
        private System.Windows.Forms.TabPage tabPageCompleted;
    }
}

