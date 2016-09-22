namespace PortfolioManager
{
    partial class CompanyDetailsTabItem
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.liveInfoPanel = new System.Windows.Forms.TableLayoutPanel();
            this.liveDataHeader = new LiveDataViewControl();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            

            //
            // liveDataHeader
            //
            this.Size = new System.Drawing.Size(570, 100);
            this.liveDataHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            //
            // closeButton
            //
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Size = new System.Drawing.Size(30, 30);
            this.closeButton.Click += CloseButton_Click;
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;

            // 
            // liveInfoPanel
            // 
            this.liveInfoPanel.ColumnCount = 2;
            this.liveInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.liveInfoPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40));
            this.liveInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.liveInfoPanel.Name = "liveInfoPanel";
            this.liveInfoPanel.RowCount = 1;
            this.liveInfoPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.liveInfoPanel.Size = new System.Drawing.Size(570, 100);
            this.liveInfoPanel.TabIndex = 0;
            this.liveInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.liveInfoPanel.Controls.Add(liveDataHeader, 0, 0);
            this.liveInfoPanel.Controls.Add(closeButton, 1, 0);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100));
            this.tableLayoutPanel.Size = new System.Drawing.Size(570, 476);
            this.tableLayoutPanel.TabIndex = 0;
            this.tableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel.Controls.Add(liveInfoPanel, 0, 0);

            // 
            // CompanyDetailsTabItem
            // 
            this.Controls.Add(tableLayoutPanel);
            this.BackColor = System.Drawing.Color.Black;
            this.Size = new System.Drawing.Size(570, 476);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel liveInfoPanel;
        private PortfolioManager.LiveDataViewControl liveDataHeader;
        private System.Windows.Forms.Button closeButton;
    }
}
