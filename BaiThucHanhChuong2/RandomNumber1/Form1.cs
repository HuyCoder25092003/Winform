using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber1
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int diem;
        public Form1()
        {
            InitializeComponent();
        }

        private void btPlay_Click(object sender, EventArgs e)
        {
            int a = r.Next(10);
            int b = r.Next(10);
            int c = r.Next(10);

            lb1.Text = a.ToString();
            lb2.Text = b.ToString();
            lb3.Text = c.ToString();

            if (a == b && a == c && b == c)
                diem += 100;
            else if (diem == 0)
                lbResult.Text = diem.ToString();
            else diem -= 10;
            lbResult.Text = diem.ToString();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không ?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
