using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1811061967_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Please checked changed!");
        }

        private void checkBox1_CheckeStateChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Please checked state changed!");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click here!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtBName.Text;
            string robot = checkBox1.CheckState == CheckState.Checked ? "is" : checkBox1.CheckState == CheckState.Unchecked ? "is not" : "phải cũng không phải là";
            string showString = string.Format("Hello {0}! You {1} robot", name, robot);

            MessageBox.Show(showString);
        }

        
    }
}
