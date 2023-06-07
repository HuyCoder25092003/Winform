using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTbac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtA.Text);
                double b = Convert.ToDouble(txtB.Text);
                double c = Convert.ToDouble(txtC.Text);
                if (a == 0)
                    txtResult.Text = String.Format("x = {0:0.##}", -c / b);
                else
                {
                    double denta = Math.Pow(b, 2) - 4 * a * c;
                    if (denta < 0)
                        txtResult.Text = String.Format("Phương trình vô nghiệm");
                    else if (denta > 0)
                        txtResult.Text = String.Format("x1 = {0:0.##} , x2 = {1:0.##}", ((-b + Math.Sqrt(denta)) / (2 * a)), ((-b - Math.Sqrt(denta)) / (2 * a)));
                    else txtResult.Text = String.Format("x = {0:0.##}", -b / (2 * a));
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập đủ số");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số bạn nhập quá to");
            }

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
