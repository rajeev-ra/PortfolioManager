using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace PortfolioManager
{
    public partial class MainUI : Form
    {
        private Control currentControl = null;
        private Button dissabledShortcut = null;
        private Point controlLocation = new Point(50, 0);
        private System.Threading.Thread liveFeed = new System.Threading.Thread(new System.Threading.ThreadStart(DataManager.WebData.StartFetch));
        public MainUI()
        {
            InitializeComponent();
            this.FormClosing += MainUI_FormClosing;
            WebData.UpdateData();
            //LiveData data = WebData.GetLiveData("TATACHEM");
            account_button.Enabled = false;
            account_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            currentControl = accountControl;
            dissabledShortcut = account_button;
            accountControl.Location = controlLocation;
            this.Controls.Add(accountControl);
            liveFeed.Start();
        }

        private void MainUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            liveFeed.Abort();
        }

        private void account_button_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = account_button;
            account_button.Enabled = false;
            account_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = accountControl;
            Size s = this.Size;
            s.Height -= 38;
            s.Width -= 65;
            currentControl.Size = s;
            currentControl.Location = controlLocation;
            this.Controls.Add(accountControl);
        }

        private void assessment_button_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = assessment_button;
            assessment_button.Enabled = false;
            assessment_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = null;
            this.Controls.Add(currentControl);
        }

        private void earnings_button_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = earnings_button;
            earnings_button.Enabled = false;
            earnings_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = null;
            this.Controls.Add(currentControl);
        }

        private void settings_button_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = settings_button;
            settings_button.Enabled = false;
            settings_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = null;
            this.Controls.Add(currentControl);
        }

        private void research_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = research_button;
            dissabledShortcut.Enabled = false;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = researchControl;
            Size s = this.Size;
            s.Height -= 38;
            s.Width -= 65;
            currentControl.Size = s;
            currentControl.Location = controlLocation;
            this.Controls.Add(currentControl);
        }

        private void watchlist_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = watchlist_button;
            dissabledShortcut.Enabled = false;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = null;
            this.Controls.Add(currentControl);
        }

        private void developer_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = developer_button;
            dissabledShortcut.Enabled = false;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = null;
            this.Controls.Add(currentControl);
        }
    }
}
