using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (txtHienThi.Text == "")
                return;
            txtHienThi.Text = txtHienThi.Text.Substring(txtHienThi.Text.Length);
        }

        private void btR_Click(object sender, EventArgs e)
        {
            if (txtHienThi.Text == "")
                return;
            txtHienThi.Text = txtHienThi.Text.Substring(0, txtHienThi.Text.Length -1);
        }

        void taoPhepToan()
        {
            try
            {
                if (txtHienThi.Text == "")
                    throw new Exception("không thể tính");

                string s = txtHienThi.Text;
                string[] number = s.Split('+', '-', 'x', '/');
                string kq = null;
                int result = int.Parse(number[0]);
                for(int i =1;i<number.Length;i++)
                {
                    int num = int.Parse(number[i]);
                    if(s.Contains('+'))
                        kq = String.Format("={0}", result + num);
                    else if (s.Contains('-'))
                        kq = String.Format("={0}", result - num);
                    else if (s.Contains('x'))
                        kq = String.Format("={0}", result * num);
                    else if (s.Contains('/'))
                    {
                        if(result == 0)
                            throw new DivideByZeroException("Không thể chia cho 0");
                        else if (num ==0)
                            kq = String.Format("=0");
                        else
                            kq = String.Format("={0:0.0}", (double)result / num);
                    }
                }
                txtHienThi.Text = txtHienThi.Text.Replace(txtHienThi.Text, s + kq);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập phép tính");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
        private void bt7_Click(object sender, EventArgs e)
        {
            Button b =(Button)sender;
            txtHienThi.Text +=b.Text;
        }

        private void btBang_Click(object sender, EventArgs e)
        {          
            taoPhepToan();
        }
    }
}
