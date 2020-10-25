using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTBUOI1_1811061967_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 0;
        void AddButton()
        {
            Random rand = new Random();
            Button b = new Button() { Text = i.ToString("Sure?"), Location = new Point(rand.Next(0, this.Size.Width), rand.Next(0, this.Size.Height)) };
            b.Click += b_Click; 
            this.Controls.Add(b);

            i++;
        }

        void b_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            MessageBox.Show("Successfull");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddButton();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddButton();
        }
    }
}
