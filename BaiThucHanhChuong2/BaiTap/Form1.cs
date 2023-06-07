using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void btDT_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                try
                {
                    if (a > 0 && b > 0 && c > 0)
                    {
                        if ((a + b >= c) && (a + c >= b) && (b + c >= a))
                        {
                            TamGiac t = new TamGiac(a, b, c);
                            lbKQ.Text = t.tinhDienTich().ToString();
                        }
                        else throw new Exception();
                    }
                }
                catch (Exception)
                {
                    lbKQ.Text = "Khong phu hop";
                }
            }
            catch
            {
                lbKQ.Text = "Ban phai nhap 3 so";
            }


        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCV_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);
            double c = double.Parse(txtC.Text);
            try
            {
                if (a > 0 && b > 0 && c > 0)
                {
                    if ((a + b >= c) && (a + c >= b) && (b + c >= a))
                    {
                        TamGiac t = new TamGiac(a, b, c);
                        lbKQ.Text = t.tinhChuVi().ToString();
                    }
                    else throw new Exception();
                }
            }
            catch (Exception)
            {
                lbKQ.Text = "Khong phu hop";
            }
        }
    }
}
