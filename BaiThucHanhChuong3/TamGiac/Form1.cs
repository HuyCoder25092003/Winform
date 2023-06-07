using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamGiac
{
    public partial class Form1 : Form
    {
        private tamGiac tg = new tamGiac();
        public Form1()
        {
            InitializeComponent();
        }

        private void btDienTich_Click(object sender, EventArgs e)
        {
            try
            {
                tg.A = Convert.ToDouble(txtCanh1.Text);
                tg.B = Convert.ToDouble(txtCanh2.Text);
                tg.C = Convert.ToDouble(txtCanh3.Text);
                if (!tg.isTamGiac())
                    throw new Exception("Không phải 3 cạnh của một tam giác");
                txtResult.Text = String.Format("{0:0.##}", tg.dienTich());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sai định dạng vui lòng nhập lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChuVi_Click(object sender, EventArgs e)
        {
            try
            {
                tg.A = Convert.ToDouble(txtCanh1.Text);
                tg.B = Convert.ToDouble(txtCanh2.Text);
                tg.C = Convert.ToDouble(txtCanh3.Text);
                if (!tg.isTamGiac())
                    throw new Exception("Không phải 3 cạnh của một tam giác");
                txtResult.Text = String.Format("{0:0.##}", tg.chuVi());
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Sai định dạng vui lòng nhập lại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
