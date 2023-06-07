using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanSo
{
    public partial class Form1 : Form
    {
        Phanso ps1=new Phanso();
        Phanso ps2 = new Phanso();
        Phanso kq;
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            try
            {
                ps1.TuSo = int.Parse(txtTuSo1.Text);
                ps1.MauSo = int.Parse(txtMauSo1.Text);
                ps2.TuSo = int.Parse(txtTuSo2.Text);
                ps2.MauSo = int.Parse(txtMauSo2.Text);

                kq = ps1.cong(ps2);
                txtTuSo3.Text = kq.TuSo.ToString();
                txtMauSo3.Text = kq.MauSo.ToString();

                label5.Text = btCong.Text;
            }
            catch
            {

            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            try
            {
                ps1.TuSo = int.Parse(txtTuSo1.Text);
                ps1.MauSo = int.Parse(txtMauSo1.Text);
                ps2.TuSo = int.Parse(txtTuSo2.Text);
                ps2.MauSo = int.Parse(txtMauSo2.Text);

                kq = ps1.tru(ps2);
                txtTuSo3.Text = kq.TuSo.ToString();
                txtMauSo3.Text = kq.MauSo.ToString();

                label5.Text = btTru.Text;
            }
            catch
            {

            }
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            try
            {
                ps1.TuSo = int.Parse(txtTuSo1.Text);
                ps1.MauSo = int.Parse(txtMauSo1.Text);
                ps2.TuSo = int.Parse(txtTuSo2.Text);
                ps2.MauSo = int.Parse(txtMauSo2.Text);

                kq = ps1.nhan(ps2);
                txtTuSo3.Text = kq.TuSo.ToString();
                txtMauSo3.Text = kq.MauSo.ToString();

                label5.Text = btNhan.Text;
            }
            catch
            {

            }
        }

        private void btChia_Click(object sender, EventArgs e)
        {
            try
            {
                ps1.TuSo = int.Parse(txtTuSo1.Text);
                ps1.MauSo = int.Parse(txtMauSo1.Text);
                ps2.TuSo = int.Parse(txtTuSo2.Text);
                ps2.MauSo = int.Parse(txtMauSo2.Text);

                kq = ps1.chia(ps2);
                txtTuSo3.Text = kq.TuSo.ToString();
                txtMauSo3.Text = kq.MauSo.ToString();

                label5.Text = btChia.Text;
            }
            catch
            {

            }
        }
    }
}
