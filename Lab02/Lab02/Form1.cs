using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_1 : Form
    {
        public Lab02_1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Viet xu li tinh tong trong sự kiện click
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float Ans = num1 + num2;
            txtAns.Text = Ans.ToString();

            try
            {
                //xử lí sự kiện cộng 2 số

            }
            catch(Exception ex)
            {
                //Khi gặp bất kì lỗi nào sẽ vào catch
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            //Viet xu li tính phép trừ trong sự kiện click
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float Ans = num1 - num2;
            txtAns.Text = Ans.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            //Viet xu li tính phép nhân trong sự kiện click
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float Ans = num1 * num2;
            txtAns.Text = Ans.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            //Viet xu li tính phép chia trong sự kiện click
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float Ans = num1 / num2;
            txtAns.Text = Ans.ToString();
        }
    }
}
