namespace PortfolioManager
{
    partial class LiveDataViewControl
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
            this.company = new System.Windows.Forms.Label();
            this.symbol = new System.Windows.Forms.Label();
            this.isin = new System.Windows.Forms.Label();
            this.latestVal = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.openLbl = new System.Windows.Forms.Label();
            this.closeLbl = new System.Windows.Forms.Label();
            this.lowLbl = new System.Windows.Forms.Label();
            this.highLbl = new System.Windows.Forms.Label();
            this.low52Lbl = new System.Windows.Forms.Label();
            this.high52Lbl = new System.Windows.Forms.Label();
            this.openVal = new System.Windows.Forms.Label();
            this.closeVal = new System.Windows.Forms.Label();
            this.lowVal = new System.Windows.Forms.Label();
            this.highVal = new System.Windows.Forms.Label();
            this.low52Val = new System.Windows.Forms.Label();
            this.high52Val = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // company
            // 
            this.company.AutoSize = true;
            this.company.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.company.Location = new System.Drawing.Point(4, 4);
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(88, 24);
            this.company.TabIndex = 0;
            this.company.Text = "company";
            // 
            // symbol
            // 
            this.symbol.AutoSize = true;
            this.symbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbol.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.symbol.Location = new System.Drawing.Point(8, 25);
            this.symbol.Name = "symbol";
            this.symbol.Size = new System.Drawing.Size(35, 12);
            this.symbol.TabIndex = 1;
            this.symbol.Text = "symbol";
            // 
            // isin
            // 
            this.isin.AutoSize = true;
            this.isin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isin.ForeColor = System.Drawing.Color.Violet;
            this.isin.Location = new System.Drawing.Point(81, 25);
            this.isin.Name = "isin";
            this.isin.Size = new System.Drawing.Size(19, 12);
            this.isin.TabIndex = 2;
            this.isin.Text = "isin";
            // 
            // latestVal
            // 
            this.latestVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestVal.ForeColor = System.Drawing.Color.Lime;
            this.latestVal.Location = new System.Drawing.Point(3, 35);
            this.latestVal.Name = "latestVal";
            this.latestVal.Size = new System.Drawing.Size(89, 24);
            this.latestVal.TabIndex = 3;
            this.latestVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.Color.Lime;
            this.change.Location = new System.Drawing.Point(98, 41);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(0, 16);
            this.change.TabIndex = 4;
            // 
            // openLbl
            // 
            this.openLbl.AutoSize = true;
            this.openLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openLbl.Location = new System.Drawing.Point(227, 25);
            this.openLbl.Name = "openLbl";
            this.openLbl.Size = new System.Drawing.Size(33, 13);
            this.openLbl.TabIndex = 5;
            this.openLbl.Text = "Open";
            // 
            // closeLbl
            // 
            this.closeLbl.AutoSize = true;
            this.closeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.closeLbl.Location = new System.Drawing.Point(227, 41);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(33, 13);
            this.closeLbl.TabIndex = 6;
            this.closeLbl.Text = "Close";
            // 
            // lowLbl
            // 
            this.lowLbl.AutoSize = true;
            this.lowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lowLbl.Location = new System.Drawing.Point(322, 41);
            this.lowLbl.Name = "lowLbl";
            this.lowLbl.Size = new System.Drawing.Size(27, 13);
            this.lowLbl.TabIndex = 8;
            this.lowLbl.Text = "Low";
            // 
            // highLbl
            // 
            this.highLbl.AutoSize = true;
            this.highLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.highLbl.Location = new System.Drawing.Point(322, 25);
            this.highLbl.Name = "highLbl";
            this.highLbl.Size = new System.Drawing.Size(29, 13);
            this.highLbl.TabIndex = 7;
            this.highLbl.Text = "High";
            // 
            // low52Lbl
            // 
            this.low52Lbl.AutoSize = true;
            this.low52Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.low52Lbl.Location = new System.Drawing.Point(411, 41);
            this.low52Lbl.Name = "low52Lbl";
            this.low52Lbl.Size = new System.Drawing.Size(39, 13);
            this.low52Lbl.TabIndex = 10;
            this.low52Lbl.Text = "Low52";
            // 
            // high52Lbl
            // 
            this.high52Lbl.AutoSize = true;
            this.high52Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.high52Lbl.Location = new System.Drawing.Point(411, 25);
            this.high52Lbl.Name = "high52Lbl";
            this.high52Lbl.Size = new System.Drawing.Size(41, 13);
            this.high52Lbl.TabIndex = 9;
            this.high52Lbl.Text = "High52";
            // 
            // openVal
            // 
            this.openVal.AutoSize = true;
            this.openVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.openVal.Location = new System.Drawing.Point(267, 25);
            this.openVal.Name = "openVal";
            this.openVal.Size = new System.Drawing.Size(0, 13);
            this.openVal.TabIndex = 11;
            // 
            // closeVal
            // 
            this.closeVal.AutoSize = true;
            this.closeVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeVal.Location = new System.Drawing.Point(267, 41);
            this.closeVal.Name = "closeVal";
            this.closeVal.Size = new System.Drawing.Size(0, 13);
            this.closeVal.TabIndex = 12;
            // 
            // lowVal
            // 
            this.lowVal.AutoSize = true;
            this.lowVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lowVal.Location = new System.Drawing.Point(357, 41);
            this.lowVal.Name = "lowVal";
            this.lowVal.Size = new System.Drawing.Size(0, 13);
            this.lowVal.TabIndex = 14;
            // 
            // highVal
            // 
            this.highVal.AutoSize = true;
            this.highVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.highVal.Location = new System.Drawing.Point(357, 25);
            this.highVal.Name = "highVal";
            this.highVal.Size = new System.Drawing.Size(0, 13);
            this.highVal.TabIndex = 13;
            // 
            // low52Val
            // 
            this.low52Val.AutoSize = true;
            this.low52Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.low52Val.Location = new System.Drawing.Point(458, 41);
            this.low52Val.Name = "low52Val";
            this.low52Val.Size = new System.Drawing.Size(0, 13);
            this.low52Val.TabIndex = 16;
            // 
            // high52Val
            // 
            this.high52Val.AutoSize = true;
            this.high52Val.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.high52Val.Location = new System.Drawing.Point(458, 25);
            this.high52Val.Name = "high52Val";
            this.high52Val.Size = new System.Drawing.Size(0, 13);
            this.high52Val.TabIndex = 15;
            // 
            // LiveDataViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.Controls.Add(this.low52Val);
            this.Controls.Add(this.high52Val);
            this.Controls.Add(this.lowVal);
            this.Controls.Add(this.highVal);
            this.Controls.Add(this.closeVal);
            this.Controls.Add(this.openVal);
            this.Controls.Add(this.low52Lbl);
            this.Controls.Add(this.high52Lbl);
            this.Controls.Add(this.lowLbl);
            this.Controls.Add(this.highLbl);
            this.Controls.Add(this.closeLbl);
            this.Controls.Add(this.openLbl);
            this.Controls.Add(this.change);
            this.Controls.Add(this.latestVal);
            this.Controls.Add(this.isin);
            this.Controls.Add(this.symbol);
            this.Controls.Add(this.company);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LiveDataViewControl";
            this.Size = new System.Drawing.Size(512, 61);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label company;
        private System.Windows.Forms.Label symbol;
        private System.Windows.Forms.Label isin;
        private System.Windows.Forms.Label latestVal;
        private System.Windows.Forms.Label change;
        private System.Windows.Forms.Label openLbl;
        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.Label lowLbl;
        private System.Windows.Forms.Label highLbl;
        private System.Windows.Forms.Label low52Lbl;
        private System.Windows.Forms.Label high52Lbl;
        private System.Windows.Forms.Label openVal;
        private System.Windows.Forms.Label closeVal;
        private System.Windows.Forms.Label lowVal;
        private System.Windows.Forms.Label highVal;
        private System.Windows.Forms.Label low52Val;
        private System.Windows.Forms.Label high52Val;
    }
}
