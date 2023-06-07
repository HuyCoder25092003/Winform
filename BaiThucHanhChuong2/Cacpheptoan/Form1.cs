using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacpheptoan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                int b = int.Parse(txt2.Text);
                btKetQua.Text = (a+b).ToString();
            }
            catch (FormatException)
            {
                btKetQua.Text = "Vui lòng nhập đủ 2 số";
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                int b = int.Parse(txt2.Text);
                btKetQua.Text = (a - b).ToString();
            }
            catch (FormatException)
            {
                btKetQua.Text = "Vui lòng nhập đủ 2 số";
            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                int b = int.Parse(txt2.Text);
                btKetQua.Text = (a * b).ToString();
            }
            catch (FormatException)
            {
                btKetQua.Text = "Vui lòng nhập đủ 2 số";
            }
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txt1.Text);
                int b = int.Parse(txt2.Text);
                if (b == 0)
                    throw new DivideByZeroException();
                btKetQua.Text=string.Format("{0:0.##}", (double)a/b);
            }
            catch (DivideByZeroException)
            {
                btKetQua.Text = "Không thể chia cho 0";
            }
            catch (FormatException)
            {
                btKetQua.Text = "Vui lòng nhập đủ 2 số";
            }
        }
    }
}
