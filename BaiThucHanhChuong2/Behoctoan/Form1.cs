using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Behoctoan
{
    public partial class Form1 : Form
    {
        Random r =new Random();
        string[] arr = { "+", "-", "x", "/" };
        int index;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            txtTraLoi.Text +=b.Text;
        }
        private void taoPhepToan()
        {
            int a = r.Next(10);
            int b = r.Next(10);
            index = r.Next(4);
            lb1.Text = a.ToString();
            lb2.Text = arr[index];
            lb3.Text = b.ToString();
            txtTraLoi.Text = "";
            txtTraLoi.Focus();
            lbKetQua.Text = "";
        }
        private void btTiepTuc_Click(object sender, EventArgs e)
        {
            taoPhepToan();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(lb1.Text);
                int b = int.Parse(lb3.Text);
                int traLoi = int.Parse(txtTraLoi.Text);
                int dapan = 0;
                switch (index)
                {
                    case 0:
                        dapan = a + b;
                        break;
                    case 1:
                        dapan = a - b;
                        break;
                    case 2:
                        dapan = a * b;
                        break;
                    case 3:
                        try
                        {
                            if (b == 0)
                                throw new DivideByZeroException();
                            else dapan = a / b;
                        }
                        catch (DivideByZeroException)
                        {
                            lbKetQua.Text = "Không thể chia cho 0";
                        }
                        break;
                }
                if (dapan == traLoi)
                    lbKetQua.Text = "Đúng rồi!";
                else lbKetQua.Text = String.Format("Sai rồi! Kết quả là {0}", dapan);
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            taoPhepToan();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtTraLoi.Text != "")
                return;
            txtTraLoi.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtTraLoi.Text == "")
                return;
            txtTraLoi.Text=txtTraLoi.Text.Substring(0,txtTraLoi.Text.Length - 1);
        }
    }
}
