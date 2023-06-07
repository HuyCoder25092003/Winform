using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuaySo
{
    public partial class Form1 : Form
    {
        string path;
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path = Application.StartupPath + @"\HinhXucxac\";
            lbName.Text = "    2151050158-Nguyễn Đức Huy    ";
            picSo1.Image = picSo2.Image = picSo3.Image = Image.FromFile(path+"6.bmp");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbName.Text = lbName.Text.Substring(1) + lbName.Text.Substring(0, 1);
        }

        void Play()
        {
            int a = r.Next(1, 7);
            int b = r.Next(1, 7);
            int c = r.Next(1, 7);
            picSo1.Image = Image.FromFile(path + a.ToString() + ".bmp");
            picSo2.Image = Image.FromFile(path + b.ToString() + ".bmp");
            picSo3.Image = Image.FromFile(path + c.ToString() + ".bmp");

            lbResult.Text = String.Format("{0}", a + b + c);
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            Play();
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
