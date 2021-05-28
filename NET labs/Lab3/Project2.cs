using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Project2 : Form
    {
        public Project2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox.AppendText(inputBox.Text);
            outputBox.AppendText("\r\n");
            //textBox2.AppendText(textbox1.text)
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Project1_Load(object sender, EventArgs e)
        {

        }
    }
}
