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
            this.txtWheelClicks = new System.Windows.Forms.TextBox();
            this.lblWheelClicks = new System.Windows.Forms.Label();
            this.txtRightClicks = new System.Windows.Forms.TextBox();
            this.lblRightClicks = new System.Windows.Forms.Label();
            this.txtLeftClicks = new System.Windows.Forms.TextBox();
            this.lblLeftClicks = new System.Windows.Forms.Label();
            this.txtWheelDistance = new System.Windows.Forms.TextBox();
            this.lblWheelDistance = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.linkDakovNet = new System.Windows.Forms.LinkLabel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblElapsedTime = new System.Windows.Forms.Label();
            this.txtStarDate = new System.Windows.Forms.TextBox();
            this.txtElapsedTime = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtWheelClicks
            // 
            this.txtWheelClicks.Enabled = false;
            this.txtWheelClicks.Location = new System.Drawing.Point(127, 104);
            this.txtWheelClicks.Name = "txtWheelClicks";
            this.txtWheelClicks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWheelClicks.Size = new System.Drawing.Size(86, 20);
            this.txtWheelClicks.TabIndex = 8;
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
            // txtWheelDistance
            // 
            this.txtWheelDistance.Enabled = false;
            this.txtWheelDistance.Location = new System.Drawing.Point(127, 26);
            this.txtWheelDistance.Name = "txtWheelDistance";
            this.txtWheelDistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWheelDistance.Size = new System.Drawing.Size(86, 20);
            this.txtWheelDistance.TabIndex = 2;
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
            this.lblCreatedBy.Location = new System.Drawing.Point(185, 156);
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
            this.linkDakovNet.Location = new System.Drawing.Point(244, 156);
            this.linkDakovNet.Name = "linkDakovNet";
            this.linkDakovNet.Size = new System.Drawing.Size(39, 13);
            this.linkDakovNet.TabIndex = 11;
            this.linkDakovNet.TabStop = true;
            this.linkDakovNet.Text = "Dakov";
            this.linkDakovNet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDakovNet_LinkClicked);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(240, 101);
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
            this.lblStartDate.Location = new System.Drawing.Point(279, 25);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblStartDate.TabIndex = 13;
            this.lblStartDate.Text = "Start Time";
            // 
            // lblElapsedTime
            // 
            this.lblElapsedTime.AutoSize = true;
            this.lblElapsedTime.Location = new System.Drawing.Point(238, 51);
            this.lblElapsedTime.Name = "lblElapsedTime";
            this.lblElapsedTime.Size = new System.Drawing.Size(96, 13);
            this.lblElapsedTime.TabIndex = 14;
            this.lblElapsedTime.Text = "Elapsed Time (min)";
            // 
            // txtStarDate
            // 
            this.txtStarDate.Enabled = false;
            this.txtStarDate.Location = new System.Drawing.Point(340, 22);
            this.txtStarDate.Name = "txtStarDate";
            this.txtStarDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStarDate.Size = new System.Drawing.Size(55, 20);
            this.txtStarDate.TabIndex = 15;
            // 
            // txtElapsedTime
            // 
            this.txtElapsedTime.Enabled = false;
            this.txtElapsedTime.Location = new System.Drawing.Point(340, 48);
            this.txtElapsedTime.Name = "txtElapsedTime";
            this.txtElapsedTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtElapsedTime.Size = new System.Drawing.Size(55, 20);
            this.txtElapsedTime.TabIndex = 16;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(330, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 195);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtElapsedTime);
            this.Controls.Add(this.txtStarDate);
            this.Controls.Add(this.lblElapsedTime);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.linkDakovNet);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.txtWheelClicks);
            this.Controls.Add(this.lblWheelClicks);
            this.Controls.Add(this.txtRightClicks);
            this.Controls.Add(this.lblRightClicks);
            this.Controls.Add(this.txtLeftClicks);
            this.Controls.Add(this.lblLeftClicks);
            this.Controls.Add(this.txtWheelDistance);
            this.Controls.Add(this.lblWheelDistance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Mouse Event Counter v1.01";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWheelClicks;
        private System.Windows.Forms.Label lblWheelClicks;
        private System.Windows.Forms.TextBox txtRightClicks;
        private System.Windows.Forms.Label lblRightClicks;
        private System.Windows.Forms.TextBox txtLeftClicks;
        private System.Windows.Forms.Label lblLeftClicks;
        private System.Windows.Forms.TextBox txtWheelDistance;
        private System.Windows.Forms.Label lblWheelDistance;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.LinkLabel linkDakovNet;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblElapsedTime;
        private System.Windows.Forms.TextBox txtStarDate;
        private System.Windows.Forms.TextBox txtElapsedTime;
        private System.Windows.Forms.Button btnSave;
    }
}

