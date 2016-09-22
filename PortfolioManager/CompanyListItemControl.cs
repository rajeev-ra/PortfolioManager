using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioManager
{
    public partial class CompanyListItemControl : UserControl
    {
        public CompanyListItemControl(String company, String symbol, String isin)
        {
            InitializeComponent();
            this.company.Text = company;
            this.symbol.Text = symbol;
            this.isin.Text = isin;
            if(company.Length > 0)
            {
                this.toolTip.SetToolTip(this, company);
                this.toolTip.SetToolTip(this.company, company);
                this.toolTip.SetToolTip(this.symbol, company);
                this.toolTip.SetToolTip(this.isin, company);
            }
        }

        public bool Contains(string search)
        {
            if (this.company.Text.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return true;
            }
            else if (this.symbol.Text.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return true;
            }
            else if (this.isin.Text.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return true;
            }
            return false;
        }

        private void CompanyListItemControl_Click(object sender, EventArgs e)
        {
            researchControl.AddTab(company.Text, symbol.Text, isin.Text);
        }
    }
}
