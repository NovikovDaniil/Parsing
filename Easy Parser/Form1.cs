using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;

namespace Easy_Parser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string GetDataFormBank(ParserSettings settings)
        {
            WebClient webClient = new WebClient();
            string htmlPage = webClient.DownloadString(settings.Url);
            return settings.Regex.Match(htmlPage).Groups[1].Value;
        }

        private void SberBankData()
        {
            ParserSettings sberBank = new ParserSettings()
            {
                Url = "https://www.sberbank.ru/ru/quotes/currencies",
                Regex = new Regex(@"<span class=""rates-current__rate-value"">(\d+,\d+)</span>")
            };
            SberTextBox.Text = GetDataFormBank(sberBank);
        }

        private void VTBBankData()
        {
            ParserSettings vtbBank = new ParserSettings()
            {
                Url = "https://www.vtb.ru/personal/platezhi-i-perevody/obmen-valjuty/",
                Regex = new Regex(@"<div class=""base-table__toggler_item"">.+""(\d+,\d+).+""</div>")

            };

            VTBTextBox.Text = GetDataFormBank(vtbBank);
        }

        private void RossBank()
        {
            ParserSettings rossBank = new ParserSettings()
            {
                Url = "https://www.rshb.ru/branches/archangelic/",
                Regex = new Regex(@"<td>(\d+\.\d+)</td>")
            };
            RossTextBox.Text = GetDataFormBank(rossBank);
        }
        private void getDataButton_Click(object sender, EventArgs e)
        {
            RossBank();
            VTBBankData();
            SberBankData();
        }
    }
}
