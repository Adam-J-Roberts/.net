using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string parse = inputBox.Text;
            Regex rg = new Regex(patternBox.Text);
            string print = null;

            foreach(string match in rg.Split(parse))
            {
                print += match + System.Environment.NewLine;
            }

            resultsBox.Text = print;
        }

        private void patternBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string parse = inputBox.Text;
            Regex rg = new Regex(patternBox.Text);
            string print = null;

            foreach (string match in rg.Split(parse))
            {
                print += match + System.Environment.NewLine;
            }

            resultsBox.Text = print;
        }
    }
}
