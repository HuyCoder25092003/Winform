using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HieuChinhPhanSo
{
    public partial class Form1 : Form
    {
        string[] operators = { "+", "-", "*", "/" };
        PhanSo fPhanSo1 = new PhanSo();
        PhanSo fPhanSo2 = new PhanSo();
        PhanSo fKetQua = new PhanSo();
        PhanSo fTraLoi = new PhanSo();
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void TinhToan(string toanTu)
        {
            try
            {
                if (txtTu2.Text == "0" && toanTu == "/")
                {
                    throw new PhanSoException("Mẫu không thể bằng 0. Nhập lại!");
                }
                fPhanSo1.Tu  = Convert.ToInt16(txtTuSo1.Text);
                fPhanSo1.Mau = Convert.ToInt16(txtMau1.Text);
                fPhanSo2.Tu  = Convert.ToInt16(txtTu2.Text);
                fPhanSo2.Mau = Convert.ToInt16(txtMau2.Text);
                switch (toanTu)
                {
                    case "+": fKetQua = fPhanSo1 + fPhanSo2; break;
                    case "-": fKetQua = fPhanSo1 - fPhanSo2; break;
                    case "*": fKetQua = fPhanSo1 * fPhanSo2; break;
                    case "/": fKetQua = fPhanSo1 / fPhanSo2; break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Định dạng không hợp lệ. Nhập lại!");
            }
            catch (PhanSoException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            TinhToan(((Button)sender).Text);
            lbToanTu.Text = ((Button)sender).Text;
            lbBang.Text = "=";
            txtTu3.Text = fKetQua.Tu.ToString();
            txtMau3.Text = fKetQua.Mau.ToString();
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            btnCong.Enabled = true;
            btnTru.Enabled = true;
            btnNhan.Enabled = true;
            btnChia.Enabled = true;
            btnXemDA.Enabled = false;
            pnlKetQua.Enabled = false;
            txtTuSo1.Text = "";
            txtMau1.Text = "";
            txtTu2.Text = "";
            txtMau2.Text = "";
            txtTu3.Text = "";
            txtMau3.Text = "";
            lbBang.Text = "...";
            lbToanTu.Text = "...";
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            btnCong.Enabled = false;
            btnTru.Enabled = false;
            btnNhan.Enabled = false;
            btnChia.Enabled = false;
            btnXemDA.Enabled = true;
            pnlKetQua.Enabled = true;
            txtTu3.Text = "";
            txtMau3.Text = "";
            int tu1 = random.Next(0, 11), tu2 = random.Next(0, 11);
            int mau1 = random.Next(1, 11), mau2 = random.Next(1, 11);
            int index = random.Next(0, operators.Length);
            while (tu2 == 0 && operators[index] == "/")
            {
                tu1 = random.Next(0, 11); tu2 = random.Next(0, 11);
                mau1 = random.Next(1, 11); mau2 = random.Next(1, 11);
                index = random.Next(0, operators.Length);
            }
            txtTuSo1.Text = tu1.ToString();
            txtMau1.Text = mau1.ToString();
            txtTu2.Text = tu2.ToString();
            txtMau2.Text = mau2.ToString();
            lbToanTu.Text = operators[index];
            lbBang.Text = "=";
        }

        private void btnXemDA_Click(object sender, EventArgs e)
        {
            TinhToan(lbToanTu.Text);
            string notification;
            try
            {
                fTraLoi.Tu = Convert.ToInt16(txtTu3.Text);
                fTraLoi.Mau = Convert.ToInt16(txtMau3.Text);
                if (fKetQua == fTraLoi)
                {
                    notification = "Bạn đã làm đúng. Ấn Random để tiếp tục!";
                }
                else
                {
                    notification = string.Format("Sai rồi. Đáp án đúng là {0} / {1}", fKetQua.Tu, fKetQua.Mau);
                }

                MessageBox.Show(notification);
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng điền đáp án trước khi xem!");
            }
        }
    }
}
