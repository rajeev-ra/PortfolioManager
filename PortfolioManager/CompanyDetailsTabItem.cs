using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.WinForms;

namespace PortfolioManager
{
    public partial class CompanyDetailsTabItem : TabPage
    {
        private string _symbol = "";
        public CompanyDetailsTabItem(string company, string symbol, string isin)
        {
            InitializeComponent();
            this.liveDataHeader.SetData(company, symbol, isin);
            this.Text = company;
            this.Name = company;
            this._symbol = symbol;
        }
        
        private void CloseButton_Click(object sender, System.EventArgs e)
        {
            DataManager.WebData.RemoveCallBack(_symbol, this.liveDataHeader.UpdateLive);
            researchControl.RemoveTab(this);
        }
    }
}
