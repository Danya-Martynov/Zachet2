using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) 
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) 
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) 
            {
                e.Handled = true;
            }
        }

        private void btnVychisl_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtbNum1.Text);
            int num2 = Convert.ToInt32(txtbNum2.Text);
            int num3 = Convert.ToInt32(txtbNum3.Text);
            int num4 = Convert.ToInt32(txtbNum4.Text);
            int c1 = 0;
            int c2 = 0;
            int c3 = 0;
            int c4 = 0;
            int max1, max2, max = 0;

            if (num1 % 2 == 0)
            {
                c1 = num1;
            }
            if (num2 % 2 == 0)
            {
                c2 = num2;
            }
            if (num3 % 2 == 0)
            {
                c3 = num3;
            }
            if (num4 % 2 == 0)
            {
                c4 = num4;
            }
            if (c1 > c2)
            {
                max1 = c1;
            }
            else max1 = c2;
            if (c3 > c4)
            {
                max2 = c3;
            }
            else max2 = c4;
            if (max1 > max2)
                max = max1;
            else max = max2;

            if (max != 0)   
            lblResult.Text = Convert.ToString(max);
            else lblResult.Text = "Not Found";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Green;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
