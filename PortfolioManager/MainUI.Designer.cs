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
            this.account_button = new System.Windows.Forms.Button();
            this.assessment_button = new System.Windows.Forms.Button();
            this.earnings_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.shortcut_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // shortcut_panel
            // 
            this.shortcut_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.shortcut_panel.BackColor = System.Drawing.SystemColors.WindowText;
            this.shortcut_panel.Controls.Add(this.update_button);
            this.shortcut_panel.Controls.Add(this.settings_button);
            this.shortcut_panel.Controls.Add(this.earnings_button);
            this.shortcut_panel.Controls.Add(this.assessment_button);
            this.shortcut_panel.Controls.Add(this.account_button);
            this.shortcut_panel.Location = new System.Drawing.Point(0, 0);
            this.shortcut_panel.Margin = new System.Windows.Forms.Padding(0);
            this.shortcut_panel.Name = "shortcut_panel";
            this.shortcut_panel.Size = new System.Drawing.Size(66, 555);
            this.shortcut_panel.TabIndex = 0;
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.account_button.BackgroundImage = global::PortfolioManager.Properties.Resources.account;
            this.account_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.account_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.account_button.FlatAppearance.BorderSize = 0;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account_button.Location = new System.Drawing.Point(1, 1);
            this.account_button.Margin = new System.Windows.Forms.Padding(1);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(64, 64);
            this.account_button.TabIndex = 0;
            this.account_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.account_button, "Account");
            this.account_button.UseVisualStyleBackColor = false;
            // 
            // assessment_button
            // 
            this.assessment_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.assessment_button.BackgroundImage = global::PortfolioManager.Properties.Resources.assessment;
            this.assessment_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.assessment_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.assessment_button.FlatAppearance.BorderSize = 0;
            this.assessment_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assessment_button.Location = new System.Drawing.Point(2, 67);
            this.assessment_button.Margin = new System.Windows.Forms.Padding(1);
            this.assessment_button.Name = "assessment_button";
            this.assessment_button.Size = new System.Drawing.Size(64, 64);
            this.assessment_button.TabIndex = 1;
            this.assessment_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.assessment_button, "Assessment");
            this.assessment_button.UseVisualStyleBackColor = false;
            // 
            // earnings_button
            // 
            this.earnings_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.earnings_button.BackgroundImage = global::PortfolioManager.Properties.Resources.earning;
            this.earnings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.earnings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.earnings_button.FlatAppearance.BorderSize = 0;
            this.earnings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.earnings_button.Location = new System.Drawing.Point(2, 133);
            this.earnings_button.Margin = new System.Windows.Forms.Padding(1);
            this.earnings_button.Name = "earnings_button";
            this.earnings_button.Size = new System.Drawing.Size(64, 64);
            this.earnings_button.TabIndex = 2;
            this.earnings_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.earnings_button, "Earnings");
            this.earnings_button.UseVisualStyleBackColor = false;
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.settings_button.BackgroundImage = global::PortfolioManager.Properties.Resources.settings;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.settings_button.FlatAppearance.BorderSize = 0;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings_button.Location = new System.Drawing.Point(2, 199);
            this.settings_button.Margin = new System.Windows.Forms.Padding(1);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(64, 64);
            this.settings_button.TabIndex = 3;
            this.settings_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.settings_button, "Settings");
            this.settings_button.UseVisualStyleBackColor = false;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.MenuText;
            this.update_button.BackgroundImage = global::PortfolioManager.Properties.Resources.update;
            this.update_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.update_button.FlatAppearance.BorderSize = 0;
            this.update_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update_button.Location = new System.Drawing.Point(2, 265);
            this.update_button.Margin = new System.Windows.Forms.Padding(1);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(64, 64);
            this.update_button.TabIndex = 4;
            this.update_button.TabStop = false;
            this.account_button_tooltip.SetToolTip(this.update_button, "Update");
            this.update_button.UseVisualStyleBackColor = false;
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.shortcut_panel);
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
        private Button update_button;
        private Button settings_button;
        private Button earnings_button;
        private Button assessment_button;
    }
}

