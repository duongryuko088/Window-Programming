using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1811061967_BTBUOI1_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox3.Text;
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int num = 0;

            if (Int32.TryParse(textBox4.Text, out num))
                label2.Text = (num * num).ToString();
            else
                label2.Text = "Wrong!Please try again.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
