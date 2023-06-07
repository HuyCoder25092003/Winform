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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a = checked(int.Parse(txt1.Text));
                int b = checked(int.Parse(txt2.Text));
                if (rdCong.Checked)
                    btKetQua.Text = string.Format("{0}", checked(a+b));
                else if (rdTru.Checked)
                    btKetQua.Text = string.Format("{0}", checked(a - b));
                else if(rdNhan.Checked)
                    btKetQua.Text= string.Format("{0}", checked(a * b));
                else if(rdChiaDu.Checked)
                    btKetQua.Text = string.Format("{0}", a % b);
                else
                {
                    if (b == 0)
                        throw new DivideByZeroException();
                    btKetQua.Text = string.Format("{0:0.##}", (double)a / b);
                }
            }
            catch (DivideByZeroException)
            {
                btKetQua.Text = "Không thể chia cho 0";
            }
            catch (FormatException)
            {
                btKetQua.Text = "Vui lòng nhập đủ 2 số";
            }
            catch(OverflowException)
            {
                btKetQua.Text = "Số bạn quá lớn hoặc quá nhỏ";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdChia_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdNhan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdTru_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdCong_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
