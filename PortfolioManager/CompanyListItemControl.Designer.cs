namespace PortfolioManager
{
    partial class CompanyListItemControl
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
            this.components = new System.ComponentModel.Container();
            this.company = new System.Windows.Forms.Label();
            this.symbol = new System.Windows.Forms.Label();
            this.isin = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.Color.Yellow;
            this.company.Location = new System.Drawing.Point(8, 2);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(64, 25);
            this.company.TabIndex = 0;
            this.company.Text = "label1";
            this.company.Click += new System.EventHandler(this.CompanyListItemControl_Click);
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.symbol.Location = new System.Drawing.Point(10, 35);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(46, 17);
            this.symbol.TabIndex = 1;
            this.symbol.Text = "label2";
            this.symbol.Click += new System.EventHandler(this.CompanyListItemControl_Click);
            // 
            // isin
            // 
            this.isin.AutoSize = true;
            this.isin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.isin.Location = new System.Drawing.Point(128, 35);
            this.isin.Name = "isin";
            this.isin.Size = new System.Drawing.Size(46, 17);
            this.isin.TabIndex = 2;
            this.isin.Text = "label3";
            this.isin.Click += new System.EventHandler(this.CompanyListItemControl_Click);
            // 
            // CompanyListItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.isin);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.company);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CompanyListItemControl";
            this.Size = new System.Drawing.Size(252, 58);
            this.Click += new System.EventHandler(this.CompanyListItemControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Label isin;
        public System.Windows.Forms.ToolTip toolTip;
    }
}
