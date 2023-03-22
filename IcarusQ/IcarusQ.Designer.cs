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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnServiceCompleteRegular = new System.Windows.Forms.Button();
            this.btnServiceCompleteExpress = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvExpress = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.lvCompleted = new System.Windows.Forms.ListView();
            this.btnRemoveComplete = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbServiceProblem = new System.Windows.Forms.TextBox();
            this.nServiceTag = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.rbtnExpress = new System.Windows.Forms.RadioButton();
            this.groupServiceType = new System.Windows.Forms.GroupBox();
            this.btnAddService = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nServiceTag)).BeginInit();
            this.groupServiceType.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvRegular
            // 
            this.lvRegular.HideSelection = false;
            this.lvRegular.Location = new System.Drawing.Point(7, 32);
            this.lvRegular.Name = "lvRegular";
            this.lvRegular.Size = new System.Drawing.Size(132, 343);
            this.lvRegular.TabIndex = 0;
            this.lvRegular.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnServiceCompleteExpress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lvExpress);
            this.groupBox1.Controls.Add(this.btnServiceCompleteRegular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lvRegular);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regular Service";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(972, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnServiceCompleteRegular
            // 
            this.btnServiceCompleteRegular.Location = new System.Drawing.Point(7, 381);
            this.btnServiceCompleteRegular.Name = "btnServiceCompleteRegular";
            this.btnServiceCompleteRegular.Size = new System.Drawing.Size(132, 23);
            this.btnServiceCompleteRegular.TabIndex = 2;
            this.btnServiceCompleteRegular.Text = "Service Complete";
            this.btnServiceCompleteRegular.UseVisualStyleBackColor = true;
            // 
            // btnServiceCompleteExpress
            // 
            this.btnServiceCompleteExpress.Location = new System.Drawing.Point(145, 381);
            this.btnServiceCompleteExpress.Name = "btnServiceCompleteExpress";
            this.btnServiceCompleteExpress.Size = new System.Drawing.Size(132, 23);
            this.btnServiceCompleteExpress.TabIndex = 5;
            this.btnServiceCompleteExpress.Text = "Service Complete";
            this.btnServiceCompleteExpress.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Express Service";
            // 
            // lvExpress
            // 
            this.lvExpress.HideSelection = false;
            this.lvExpress.Location = new System.Drawing.Point(145, 32);
            this.lvExpress.Name = "lvExpress";
            this.lvExpress.Size = new System.Drawing.Size(132, 343);
            this.lvExpress.TabIndex = 3;
            this.lvExpress.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Completed Services";
            // 
            // lvCompleted
            // 
            this.lvCompleted.HideSelection = false;
            this.lvCompleted.Location = new System.Drawing.Point(6, 32);
            this.lvCompleted.Name = "lvCompleted";
            this.lvCompleted.Size = new System.Drawing.Size(132, 343);
            this.lvCompleted.TabIndex = 6;
            this.lvCompleted.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemoveComplete
            // 
            this.btnRemoveComplete.Location = new System.Drawing.Point(6, 381);
            this.btnRemoveComplete.Name = "btnRemoveComplete";
            this.btnRemoveComplete.Size = new System.Drawing.Size(132, 23);
            this.btnRemoveComplete.TabIndex = 8;
            this.btnRemoveComplete.Text = "Remove Selected";
            this.btnRemoveComplete.UseVisualStyleBackColor = true;
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
            this.groupBox2.Text = "Create New Service";
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
            this.nServiceTag.Size = new System.Drawing.Size(130, 20);
            this.nServiceTag.TabIndex = 17;
            this.nServiceTag.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
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
            this.tbCost.Size = new System.Drawing.Size(87, 20);
            this.tbCost.TabIndex = 19;
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
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(5, 381);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(223, 26);
            this.btnAddService.TabIndex = 21;
            this.btnAddService.Text = "Add Service";
            this.btnAddService.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.tbOutput);
            this.groupBox4.Controls.Add(this.btnRemoveComplete);
            this.groupBox4.Controls.Add(this.lvCompleted);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(542, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(422, 413);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Completed Services";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(145, 31);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(271, 373);
            this.tbOutput.TabIndex = 9;
            this.tbOutput.Text = "Select a completed service to view details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Details";
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // IcarusQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "IcarusQ";
            this.Text = "IcarusQ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nServiceTag)).EndInit();
            this.groupServiceType.ResumeLayout(false);
            this.groupServiceType.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvRegular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveComplete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvCompleted;
        private System.Windows.Forms.Button btnServiceCompleteExpress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvExpress;
        private System.Windows.Forms.Button btnServiceCompleteRegular;
        private System.Windows.Forms.StatusStrip statusStrip1;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOutput;
    }
}

