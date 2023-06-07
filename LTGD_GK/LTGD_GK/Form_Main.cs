using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTGD_GK
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Thông báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnString(object sender, EventArgs e)
        {
            Form f = new Form_XuLyChuoi();
            f.MdiParent = this;
            f.Show();
        }

        private void BtnDraw(object sender, EventArgs e)
        {
            Form f = new Form_Ve();
            f.MdiParent = this;
            f.Show();
        }

        private void BtnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
