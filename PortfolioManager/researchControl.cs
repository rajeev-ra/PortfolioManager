using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PortfolioManager
{
    public partial class researchControl : UserControl
    {
        private static researchControl _this = null;
        public researchControl()
        {
            InitializeComponent();
            _this = this;

            CompanyDetailsTabItem page = new CompanyDetailsTabItem();
            page.Text = "Nifty";
            companyDetailsTabControl.TabPages.Add(page);
        }

        public static void AddTab(string company, string symbol)
        {
            CompanyDetailsTabItem page = new CompanyDetailsTabItem();
            page.Text = company;
            _this.companyDetailsTabControl.TabPages.Add(page);
            _this.companyDetailsTabControl.SelectTab(page);
        }
    }
}
