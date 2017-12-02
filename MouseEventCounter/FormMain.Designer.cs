namespace MouseEventCounter
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtScrollClicks = new System.Windows.Forms.TextBox();
            this.lblWheelClicks = new System.Windows.Forms.Label();
            this.txtRightClicks = new System.Windows.Forms.TextBox();
            this.lblRightClicks = new System.Windows.Forms.Label();
            this.txtLeftClicks = new System.Windows.Forms.TextBox();
            this.lblLeftClicks = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblWheelDistance = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.linkDakovNet = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtStarDate = new System.Windows.Forms.TextBox();
            this.txtEndDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtScrollClicks
            // 
            this.txtScrollClicks.Enabled = false;
            this.txtScrollClicks.Location = new System.Drawing.Point(127, 104);
            this.txtScrollClicks.Name = "txtScrollClicks";
            this.txtScrollClicks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScrollClicks.Size = new System.Drawing.Size(86, 20);
            this.txtScrollClicks.TabIndex = 8;
            // 
            // lblWheelClicks
            // 
            this.lblWheelClicks.AutoSize = true;
            this.lblWheelClicks.Location = new System.Drawing.Point(57, 107);
            this.lblWheelClicks.Name = "lblWheelClicks";
            this.lblWheelClicks.Size = new System.Drawing.Size(69, 13);
            this.lblWheelClicks.TabIndex = 7;
            this.lblWheelClicks.Text = "Wheel Clicks";
            this.lblWheelClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRightClicks
            // 
            this.txtRightClicks.Enabled = false;
            this.txtRightClicks.Location = new System.Drawing.Point(127, 78);
            this.txtRightClicks.Name = "txtRightClicks";
            this.txtRightClicks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRightClicks.Size = new System.Drawing.Size(86, 20);
            this.txtRightClicks.TabIndex = 6;
            // 
            // lblRightClicks
            // 
            this.lblRightClicks.Location = new System.Drawing.Point(60, 81);
            this.lblRightClicks.Name = "lblRightClicks";
            this.lblRightClicks.Size = new System.Drawing.Size(66, 13);
            this.lblRightClicks.TabIndex = 5;
            this.lblRightClicks.Text = "Right Clicks";
            this.lblRightClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLeftClicks
            // 
            this.txtLeftClicks.Enabled = false;
            this.txtLeftClicks.Location = new System.Drawing.Point(127, 52);
            this.txtLeftClicks.Name = "txtLeftClicks";
            this.txtLeftClicks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLeftClicks.Size = new System.Drawing.Size(86, 20);
            this.txtLeftClicks.TabIndex = 4;
            // 
            // lblLeftClicks
            // 
            this.lblLeftClicks.AutoSize = true;
            this.lblLeftClicks.Location = new System.Drawing.Point(70, 55);
            this.lblLeftClicks.Name = "lblLeftClicks";
            this.lblLeftClicks.Size = new System.Drawing.Size(56, 13);
            this.lblLeftClicks.TabIndex = 3;
            this.lblLeftClicks.Text = "Left Clicks";
            this.lblLeftClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Location = new System.Drawing.Point(127, 26);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDistance.Size = new System.Drawing.Size(86, 20);
            this.txtDistance.TabIndex = 2;
            // 
            // lblWheelDistance
            // 
            this.lblWheelDistance.AutoSize = true;
            this.lblWheelDistance.Location = new System.Drawing.Point(18, 29);
            this.lblWheelDistance.Name = "lblWheelDistance";
            this.lblWheelDistance.Size = new System.Drawing.Size(108, 13);
            this.lblWheelDistance.TabIndex = 1;
            this.lblWheelDistance.Text = "Wheel Distance (mm)";
            this.lblWheelDistance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Location = new System.Drawing.Point(160, 158);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(59, 13);
            this.lblCreatedBy.TabIndex = 10;
            this.lblCreatedBy.Text = "Created By";
            // 
            // linkDakovNet
            // 
            this.linkDakovNet.ActiveLinkColor = System.Drawing.Color.Navy;
            this.linkDakovNet.AutoSize = true;
            this.linkDakovNet.LinkColor = System.Drawing.Color.Navy;
            this.linkDakovNet.Location = new System.Drawing.Point(219, 158);
            this.linkDakovNet.Name = "linkDakovNet";
            this.linkDakovNet.Size = new System.Drawing.Size(39, 13);
            this.linkDakovNet.TabIndex = 11;
            this.linkDakovNet.TabStop = true;
            this.linkDakovNet.Text = "Dakov";
            this.linkDakovNet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDakovNet_LinkClicked);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(288, 97);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(273, 26);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(29, 13);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "Start";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(273, 52);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(26, 13);
            this.lblEndDate.TabIndex = 14;
            this.lblEndDate.Text = "End";
            // 
            // txtStarDate
            // 
            this.txtStarDate.Enabled = false;
            this.txtStarDate.Location = new System.Drawing.Point(308, 23);
            this.txtStarDate.Name = "txtStarDate";
            this.txtStarDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStarDate.Size = new System.Drawing.Size(55, 20);
            this.txtStarDate.TabIndex = 15;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Enabled = false;
            this.txtEndDate.Location = new System.Drawing.Point(308, 49);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEndDate.Size = new System.Drawing.Size(55, 20);
            this.txtEndDate.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 197);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.txtStarDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.linkDakovNet);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.txtScrollClicks);
            this.Controls.Add(this.lblWheelClicks);
            this.Controls.Add(this.txtRightClicks);
            this.Controls.Add(this.lblRightClicks);
            this.Controls.Add(this.txtLeftClicks);
            this.Controls.Add(this.lblLeftClicks);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblWheelDistance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Mouse Event Counter v1.01";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScrollClicks;
        private System.Windows.Forms.Label lblWheelClicks;
        private System.Windows.Forms.TextBox txtRightClicks;
        private System.Windows.Forms.Label lblRightClicks;
        private System.Windows.Forms.TextBox txtLeftClicks;
        private System.Windows.Forms.Label lblLeftClicks;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblWheelDistance;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel linkDakovNet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtStarDate;
        private System.Windows.Forms.TextBox txtEndDate;
    }
}

