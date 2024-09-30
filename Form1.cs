using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinhCamTay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, kq;
        char pt;
        private void button0_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtHienThi.Text += "9";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = "";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienThi.Text);
            txtHienThi.Text = "";
            pt = '/';
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienThi.Text);
            txtHienThi.Text = "";
            pt = '+';
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienThi.Text);
            txtHienThi.Text = "";
            pt = '-';
        }

        private void btnPhanTram_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienThi.Text);
            a = a * 100;
            txtHienThi.Text= a + "%";
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            txtHienThi.Text = kq.ToString();
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {

        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            b = double.Parse(txtHienThi.Text);
            txtHienThi.Text = "";
            switch (pt)
            {
                case '+': kq = a + b; break;
                case '-': kq = a - b; break;
                case '*': kq = a * b; break;
                case '/':
                    if (b == 0) { MessageBox.Show("Không thể chia cho 0"); return; }
                    else kq = a / b; break;
            }
            txtHienThi.Text=kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            a = double.Parse(txtHienThi.Text);
            txtHienThi.Text = "";
            pt = '*';
        }
    }
}
