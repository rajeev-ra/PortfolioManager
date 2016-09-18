using System.Drawing;
using System.Windows.Forms;

namespace PortfolioManager
{
    partial class MainUI
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
            this.components = new System.ComponentModel.Container();
            this.shortcut_panel = new System.Windows.Forms.Panel();
            this.account_button_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.settings_button = new System.Windows.Forms.Button();
            this.earnings_button = new System.Windows.Forms.Button();
            this.assessment_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.developer_button = new System.Windows.Forms.Button();
            this.watchlist_button = new System.Windows.Forms.Button();
            this.research_button = new System.Windows.Forms.Button();
            this.researchControl = new PortfolioManager.researchControl();
            this.accountControl = new PortfolioManager.AccountControl();
            this.shortcut_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortcut_panel
            // 
            this.shortcut_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.shortcut_panel.BackColor = System.Drawing.SystemColors.WindowText;
            this.shortcut_panel.Controls.Add(this.research_button);
            this.shortcut_panel.Controls.Add(this.watchlist_button);
            this.shortcut_panel.Controls.Add(this.developer_button);
            this.shortcut_panel.Controls.Add(this.settings_button);
            this.shortcut_panel.Controls.Add(this.earnings_button);
            this.shortcut_panel.Controls.Add(this.assessment_button);
            this.shortcut_panel.Controls.Add(this.account_button);
            this.shortcut_panel.Location = new System.Drawing.Point(0, 0);
            this.shortcut_panel.Margin = new System.Windows.Forms.Padding(0);
            this.shortcut_panel.Name = "shortcut_panel";
            this.shortcut_panel.Size = new System.Drawing.Size(67, 555);
            this.shortcut_panel.TabIndex = 0;
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.settings_button.BackgroundImage = global::PortfolioManager.Properties.Resources.settings;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Location = new System.Drawing.Point(0, 309);
            this.settings_button.Margin = new System.Windows.Forms.Padding(0);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(67, 62);
            this.settings_button.TabIndex = 5;
            this.settings_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.settings_button, "Settings");
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // earnings_button
            // 
            this.earnings_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.earnings_button.BackgroundImage = global::PortfolioManager.Properties.Resources.earning;
            this.earnings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.earnings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.earnings_button.FlatAppearance.BorderSize = 0;
            this.earnings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.earnings_button.Location = new System.Drawing.Point(0, 185);
            this.earnings_button.Margin = new System.Windows.Forms.Padding(0);
            this.earnings_button.Name = "earnings_button";
            this.earnings_button.Size = new System.Drawing.Size(67, 62);
            this.earnings_button.TabIndex = 3;
            this.earnings_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.earnings_button, "Earnings");
            this.earnings_button.UseVisualStyleBackColor = false;
            this.earnings_button.Click += new System.EventHandler(this.earnings_button_Click);
            // 
            // assessment_button
            // 
            this.assessment_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.assessment_button.BackgroundImage = global::PortfolioManager.Properties.Resources.assessment;
            this.assessment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assessment_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.assessment_button.FlatAppearance.BorderSize = 0;
            this.assessment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assessment_button.Location = new System.Drawing.Point(0, 247);
            this.assessment_button.Margin = new System.Windows.Forms.Padding(0);
            this.assessment_button.Name = "assessment_button";
            this.assessment_button.Size = new System.Drawing.Size(67, 62);
            this.assessment_button.TabIndex = 4;
            this.assessment_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.assessment_button, "Assessment");
            this.assessment_button.UseVisualStyleBackColor = false;
            this.assessment_button.Click += new System.EventHandler(this.assessment_button_Click);
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.account_button.BackgroundImage = global::PortfolioManager.Properties.Resources.account;
            this.account_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Location = new System.Drawing.Point(0, 0);
            this.account_button.Margin = new System.Windows.Forms.Padding(0);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(67, 62);
            this.account_button.TabIndex = 0;
            this.account_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.account_button, "Account");
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // developer_button
            // 
            this.developer_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.developer_button.BackgroundImage = global::PortfolioManager.Properties.Resources.developer;
            this.developer_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.developer_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.developer_button.FlatAppearance.BorderSize = 0;
            this.developer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.developer_button.Location = new System.Drawing.Point(0, 371);
            this.developer_button.Margin = new System.Windows.Forms.Padding(0);
            this.developer_button.Name = "developer_button";
            this.developer_button.Size = new System.Drawing.Size(67, 62);
            this.developer_button.TabIndex = 6;
            this.developer_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.developer_button, "Developer Tools");
            this.developer_button.UseVisualStyleBackColor = false;
            this.developer_button.Click += new System.EventHandler(this.developer_Click);
            // 
            // watchlist_button
            // 
            this.watchlist_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.watchlist_button.BackgroundImage = global::PortfolioManager.Properties.Resources.watchlist;
            this.watchlist_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.watchlist_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.watchlist_button.FlatAppearance.BorderSize = 0;
            this.watchlist_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.watchlist_button.Location = new System.Drawing.Point(0, 123);
            this.watchlist_button.Margin = new System.Windows.Forms.Padding(0);
            this.watchlist_button.Name = "watchlist_button";
            this.watchlist_button.Size = new System.Drawing.Size(67, 62);
            this.watchlist_button.TabIndex = 2;
            this.watchlist_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.watchlist_button, "Watchlist");
            this.watchlist_button.UseVisualStyleBackColor = false;
            this.watchlist_button.Click += new System.EventHandler(this.watchlist_Click);
            // 
            // research_button
            // 
            this.research_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.research_button.BackgroundImage = global::PortfolioManager.Properties.Resources.research;
            this.research_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.research_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.research_button.FlatAppearance.BorderSize = 0;
            this.research_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.research_button.Location = new System.Drawing.Point(0, 61);
            this.research_button.Margin = new System.Windows.Forms.Padding(0);
            this.research_button.Name = "research_button";
            this.research_button.Size = new System.Drawing.Size(67, 62);
            this.research_button.TabIndex = 1;
            this.research_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.research_button, "Research");
            this.research_button.UseVisualStyleBackColor = false;
            this.research_button.Click += new System.EventHandler(this.research_Click);
            // 
            // researchControl
            // 
            this.researchControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.researchControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.researchControl.Location = new System.Drawing.Point(67, 0);
            this.researchControl.Margin = new System.Windows.Forms.Padding(4);
            this.researchControl.Name = "researchControl";
            this.researchControl.Size = new System.Drawing.Size(715, 555);
            this.researchControl.TabIndex = 2;
            // 
            // accountControl
            // 
            this.accountControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountControl.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.accountControl.Location = new System.Drawing.Point(67, 0);
            this.accountControl.Margin = new System.Windows.Forms.Padding(0);
            this.accountControl.Name = "accountControl";
            this.accountControl.Size = new System.Drawing.Size(715, 555);
            this.accountControl.TabIndex = 1;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 553);
            //this.Controls.Add(this.researchControl);
            //this.Controls.Add(this.accountControl);
            this.Controls.Add(this.shortcut_panel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainUI";
            this.Text = "Portfolio Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.shortcut_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel shortcut_panel;
        private System.Windows.Forms.Button account_button;
        private ToolTip account_button_tooltip;
        private Button settings_button;
        private Button earnings_button;
        private Button assessment_button;
        private AccountControl accountControl;
        private Button developer_button;
        private Button research_button;
        private Button watchlist_button;
        private researchControl researchControl;
    }
}

