using Parser.Core;
using Parser.Core.Habr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class MainForm : Form
    {
        ParserWorker<string[]> parser;
        public MainForm()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>
            (
                 new HabraParser()
            );

            parser.OnCompleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            resultListBox.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");
        }

        private void parsingButton_Click(object sender, EventArgs e)
        {
            parser.ParserSettings
                = new HabraSettings((int)startNumericUpDown.Value, (int)endNumericUpDown.Value);

            parser.Start();

        }

        private void abortButton_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
