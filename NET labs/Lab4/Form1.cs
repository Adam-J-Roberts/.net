using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_41
{
    public partial class DiceFrequency : Form
    {
       
        public DiceFrequency()
        {
            InitializeComponent();
            
        }

        private void num12_TextChanged(object sender, EventArgs e)
        {

        }

        private void num8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roll_Click(object sender, EventArgs e)
        {
            int[] track = new int[11];
            int count = 0;
            for (int i = 0; i < 11; i++) { track[i] = 0; }
            Random roll = new Random();

            do
            {
                int dice = roll.Next(2, 13);
                string myString = dice.ToString();
                outputBox.AppendText(myString);
                outputBox.AppendText("\r\n");
                track[dice - 2]++;
                count++;
            } while (count < 100000);
           // int test = 1;
           // string myOut = track[0].ToString();
            num2.AppendText(track[0].ToString());
            num3.AppendText(track[1].ToString());
            num4.AppendText(track[2].ToString());
            num5.AppendText(track[3].ToString());
            num6.AppendText(track[4].ToString());
            num7.AppendText(track[5].ToString());
            num8.AppendText(track[6].ToString());
            num9.AppendText(track[7].ToString());
            num10.AppendText(track[8].ToString());
            num11.AppendText(track[9].ToString());
            num12.AppendText(track[10].ToString());
        }
    }
}
