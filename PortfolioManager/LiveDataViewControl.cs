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
    public partial class LiveDataViewControl : UserControl
    {
        public delegate void DelegateSetVal(Control c, string val);

        private char _changeDirection = '▲'; //'▼'
        public LiveDataViewControl()
        {
            InitializeComponent();
        }

        public void SetData(string company, string symbol, string isin)
        {
            this.company.Text = company;
            this.symbol.Text = symbol;
            this.isin.Text = isin;
            DataManager.WebData.AddCallback(symbol, UpdateLive);
        }

        public int UpdateLive(DataManager.LiveData d)
        {
            /*
            SetVal(this.latestVal, d.lastPrice.ToString());
            SetVal(this.lowVal, d.dayLow.ToString());
            SetVal(this.highVal, d.dayHigh.ToString());
            SetVal(this.openVal, d.openPrice.ToString());
            */
            return 0;
        }

        private void SetVal(Control c, string val)
        {
            if(c.InvokeRequired)
            {
                //this.latestVal.Invoke(new DelegateSetVal(SetLastVal), new object[] { val });

                Invoke(new DelegateSetVal(SetVal), c, val);
            }
            else
            {
                c.Text = val;
            }
        }
    }
}
