namespace PortfolioManager
{
    partial class researchControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headingLabel = new System.Windows.Forms.Label();
            this.companyListControl = new PortfolioManager.CompanyListControl();
            this.companyDetailsTabControl = new PortfolioManager.CompanyDetailsTabControl();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.ForeColor = System.Drawing.Color.Aqua;
            this.headingLabel.Location = new System.Drawing.Point(13, 12);
            this.headingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(163, 39);
            this.headingLabel.TabIndex = 1;
            this.headingLabel.Text = "Research";
            // 
            // companyListControl
            // 
            this.companyListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.companyListControl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.companyListControl.Location = new System.Drawing.Point(20, 64);
            this.companyListControl.Margin = new System.Windows.Forms.Padding(0);
            this.companyListControl.Name = "companyListControl";
            this.companyListControl.Size = new System.Drawing.Size(252, 502);
            this.companyListControl.TabIndex = 2;
            // 
            // companyDetailsTabControl
            // 
            this.companyDetailsTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.companyDetailsTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyDetailsTabControl.Location = new System.Drawing.Point(296, 64);
            this.companyDetailsTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.companyDetailsTabControl.Name = "companyDetailsTabControl";
            this.companyDetailsTabControl.SelectedIndex = 0;
            this.companyDetailsTabControl.Size = new System.Drawing.Size(647, 502);
            this.companyDetailsTabControl.TabIndex = 3;
            // 
            // researchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.companyDetailsTabControl);
            this.Controls.Add(this.companyListControl);
            this.Controls.Add(this.headingLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "researchControl";
            this.Size = new System.Drawing.Size(960, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private CompanyListControl companyListControl;
        private CompanyDetailsTabControl companyDetailsTabControl;
    }
}
