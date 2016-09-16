using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataManager;

namespace PortfolioManager
{
    public partial class MainUI : Form
    {
        private Control currentControl = null;
        private Button dissabledShortcut = null;
        public MainUI()
        {
            InitializeComponent();
            //LiveData data = WebData.GetLiveData("TATACHEM");
            account_button.Enabled = false;
            account_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            currentControl = accountControl;
            dissabledShortcut = account_button;
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
            this.Controls.Add(null);
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
            this.Controls.Add(null);
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
            this.Controls.Add(null);
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            dissabledShortcut.Enabled = true;
            dissabledShortcut.BackColor = System.Drawing.SystemColors.WindowText;
            dissabledShortcut = update_button;
            update_button.Enabled = false;
            update_button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Remove(currentControl);
            currentControl = null;
            this.Controls.Add(null);
        }
    }
}
