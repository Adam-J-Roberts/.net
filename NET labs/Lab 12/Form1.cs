using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_12
{
    public partial class PrimeForm : Form
    {
        // Member Variables
        int prime;
        double cap;
        Thread t;


        public PrimeForm()
        {
            InitializeComponent();

            StartButton.Enabled = true;
            CancelButton.Enabled = false;
        }


        private void button_start_Click(object sender, EventArgs e)
        {
            if (!Double.TryParse(SearchTextbox.Text, out cap))
            {
                MessageBox.Show("Upper Bound is Invalid!!", "ERROR!!");
                return;
            }

            StartButton.Enabled = false;
            CancelButton.Enabled = true;

            ResultsTextbox.Text = "";
            t = new Thread(findPrimes);
            t.Start();
        }


        private void button_cancel_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = "" + prime;

            StartButton.Enabled = true;
            CancelButton.Enabled = false;

            t.Abort();
        }


        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            ResultsTextbox.Text = "" + prime;
        }


        public void ChangeButtonsState()
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action(ChangeButtonsState));
                return;
            }

            if (StartButton.Enabled)
            {
                StartButton.Enabled = false;
            }
            else
            {
                StartButton.Enabled = true;
            }


            if (CancelButton.Enabled)
            {
                CancelButton.Enabled = false;
            }
            else
            {
                CancelButton.Enabled = true;
            }
        }


        private void findPrimes()
        {
            prime = 0;
            for (int i = 2; i < cap; i++)
            {
                bool found = false;
                for (int x = 2; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    prime++;
                    AppendTextBox(prime.ToString());
                }
            }

            ChangeButtonsState();
        }

        private void CeilingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
