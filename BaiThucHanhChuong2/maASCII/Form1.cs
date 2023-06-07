using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maASCII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                    throw new Exception("Phải nhập dữ liệu");
                char ascii = (char)Convert.ToInt32(txtMa.Text);
                txtResult.Text = ascii.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập số");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btChuyen1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtKyTu.Text =="")
                    throw new Exception("Bạn đã nhập sai định dạng vui lòng nhập lại");
                byte ascii = (byte)Convert.ToChar(txtKyTu.Text);
                txtResult1.Text = ascii.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng bạn nhập");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
