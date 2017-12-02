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
            this.txtScrollClicks = new System.Windows.Forms.TextBox();
            this.lblScrollClicks = new System.Windows.Forms.Label();
            this.txtRightClicks = new System.Windows.Forms.TextBox();
            this.lblRightClicks = new System.Windows.Forms.Label();
            this.txtLeftClicks = new System.Windows.Forms.TextBox();
            this.lblLeftClicks = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtScrollClicks
            // 
            this.txtScrollClicks.Enabled = false;
            this.txtScrollClicks.Location = new System.Drawing.Point(117, 124);
            this.txtScrollClicks.Name = "txtScrollClicks";
            this.txtScrollClicks.Size = new System.Drawing.Size(100, 20);
            this.txtScrollClicks.TabIndex = 15;
            // 
            // lblScrollClicks
            // 
            this.lblScrollClicks.AutoSize = true;
            this.lblScrollClicks.Location = new System.Drawing.Point(42, 127);
            this.lblScrollClicks.Name = "lblScrollClicks";
            this.lblScrollClicks.Size = new System.Drawing.Size(70, 13);
            this.lblScrollClicks.TabIndex = 14;
            this.lblScrollClicks.Text = "Scroll Clicks :";
            // 
            // txtRightClicks
            // 
            this.txtRightClicks.Enabled = false;
            this.txtRightClicks.Location = new System.Drawing.Point(117, 98);
            this.txtRightClicks.Name = "txtRightClicks";
            this.txtRightClicks.Size = new System.Drawing.Size(100, 20);
            this.txtRightClicks.TabIndex = 13;
            // 
            // lblRightClicks
            // 
            this.lblRightClicks.AutoSize = true;
            this.lblRightClicks.Location = new System.Drawing.Point(42, 101);
            this.lblRightClicks.Name = "lblRightClicks";
            this.lblRightClicks.Size = new System.Drawing.Size(69, 13);
            this.lblRightClicks.TabIndex = 12;
            this.lblRightClicks.Text = "Right Clicks :";
            // 
            // txtLeftClicks
            // 
            this.txtLeftClicks.Enabled = false;
            this.txtLeftClicks.Location = new System.Drawing.Point(117, 72);
            this.txtLeftClicks.Name = "txtLeftClicks";
            this.txtLeftClicks.Size = new System.Drawing.Size(100, 20);
            this.txtLeftClicks.TabIndex = 11;
            // 
            // lblLeftClicks
            // 
            this.lblLeftClicks.AutoSize = true;
            this.lblLeftClicks.Location = new System.Drawing.Point(42, 75);
            this.lblLeftClicks.Name = "lblLeftClicks";
            this.lblLeftClicks.Size = new System.Drawing.Size(62, 13);
            this.lblLeftClicks.TabIndex = 10;
            this.lblLeftClicks.Text = "Left Clicks :";
            // 
            // txtDistance
            // 
            this.txtDistance.Enabled = false;
            this.txtDistance.Location = new System.Drawing.Point(117, 46);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(100, 20);
            this.txtDistance.TabIndex = 9;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(42, 49);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 8;
            this.lblDistance.Text = "Distance :";
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 201);
            this.Controls.Add(this.txtScrollClicks);
            this.Controls.Add(this.lblScrollClicks);
            this.Controls.Add(this.txtRightClicks);
            this.Controls.Add(this.lblRightClicks);
            this.Controls.Add(this.txtLeftClicks);
            this.Controls.Add(this.lblLeftClicks);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblDistance);
            this.Name = "formMain";
            this.Text = "MouseEventCounter";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtScrollClicks;
        private System.Windows.Forms.Label lblScrollClicks;
        private System.Windows.Forms.TextBox txtRightClicks;
        private System.Windows.Forms.Label lblRightClicks;
        private System.Windows.Forms.TextBox txtLeftClicks;
        private System.Windows.Forms.Label lblLeftClicks;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblDistance;
    }
}

