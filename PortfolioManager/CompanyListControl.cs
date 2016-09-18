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
    public partial class CompanyListControl : UserControl
    {
        private Button lastButton = null;
        private SortedList<char, List<Control>> companyList = new SortedList<char, List<Control>>();
        public CompanyListControl()
        {
            InitializeComponent();
            CreateCompanyList();
            lastButton = this.buttonA;
            AddCompany('A');
        }
        public void AddCompany(char c)
        {
            this.flowLayoutPanel.Controls.Clear();
            foreach (Control control in companyList[c])
            {
                this.flowLayoutPanel.Controls.Add(control);
            }
            CompanyListItemControl item = new CompanyListItemControl("","","");
            item.BackColor = System.Drawing.SystemColors.ControlDark;
            item.BorderStyle = BorderStyle.None;
            this.flowLayoutPanel.Controls.Add(item);
            item = new CompanyListItemControl("", "", "");
            item.BackColor = System.Drawing.SystemColors.ControlDark;
            item.BorderStyle = BorderStyle.None;
            this.flowLayoutPanel.Controls.Add(item);
        }

        public void CreateCompanyList()
        {
            char nextChar = 'A';
            char currentChar = '#';

            String dataPath = Directory.GetCurrentDirectory() + "\\NSC.txt";
            using (StreamReader sr = new StreamReader(dataPath))
            {
                List<Control> controlList = new List<Control>();
                String line = sr.ReadLine();
                String company = "";
                String isin = "";
                String symbol = "";
                while (line != null)
                {
                    int start = 0, end = 0;
                    end = line.IndexOf('[');
                    company = line.Substring(0, end).Trim();

                    start = end + 1;
                    end = line.IndexOf(',', start);
                    symbol = line.Substring(start, end - start).Trim();

                    start = end + 1;
                    end = line.IndexOf(']', start);
                    isin = line.Substring(start, end - start).Trim();

                    CompanyListItemControl item = new CompanyListItemControl(company, symbol, isin);
                    item.toolTip.SetToolTip(item, company);

                    if (line.ElementAt(0) != nextChar)
                    {
                        controlList.Add(item);
                    }
                    else
                    {
                        companyList.Add(currentChar, controlList);
                        controlList = new List<Control>();
                        controlList.Add(item);
                        currentChar = nextChar;
                        nextChar = (char)(Convert.ToUInt16(nextChar) + 1);
                    }
                    line = sr.ReadLine();
                }
                companyList.Add(currentChar, controlList);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(b != lastButton)
            {
                AddCompany(b.Text.ElementAt(0));
                lastButton = b;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            /*
            string search = this.searchBox.Text;
            search = search.ToUpper();
            if(search.Length == 0)
            {
                foreach(Control c in this.flowLayoutPanel.Controls)
                {
                    c.Visible = true;
                }
                return;
            }
            Button b = (Button)this.Controls["button" + search.ElementAt(0)];
            if (b != lastButton)
            {
                this.flowLayoutPanel.Controls.Clear();
                AddCompany(b.Text.ElementAt(0));
                lastButton = b;
            }
            */
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search = this.searchBox.Text;
                if(search.Length == 0)
                {
                    AddCompany(lastButton.Text.ElementAt(0));
                    return;
                }

                List<Control> searchResult = new List<Control>();
                int n = 0;

                foreach(var v in companyList)
                {
                    foreach(Control c in v.Value)
                    {
                        CompanyListItemControl company = (CompanyListItemControl)c;
                        if(company.Contains(search))
                        {
                            n++;
                            searchResult.Add(c);
                        }
                        if (n > 100)
                            break;
                    }
                    if (n > 100)
                        break;
                }

                this.flowLayoutPanel.Controls.Clear();
                foreach (Control control in searchResult)
                {
                    this.flowLayoutPanel.Controls.Add(control);
                }
                CompanyListItemControl item = new CompanyListItemControl("", "", "");
                item.BackColor = System.Drawing.SystemColors.ControlDark;
                item.BorderStyle = BorderStyle.None;
                this.flowLayoutPanel.Controls.Add(item);
                item = new CompanyListItemControl("", "", "");
                item.BackColor = System.Drawing.SystemColors.ControlDark;
                item.BorderStyle = BorderStyle.None;
                this.flowLayoutPanel.Controls.Add(item);
            }
        }
    }
}
