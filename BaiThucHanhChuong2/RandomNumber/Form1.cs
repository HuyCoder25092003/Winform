using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int diem;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btQuaySo_Click(object sender, EventArgs e)
        {
            int so1 = r.Next(1, 7);
            int so2 = r.Next(1, 7);
            int so3 = r.Next(1, 7);
            lb1.Text = so1.ToString();
            lb2.Text = so2.ToString();
            lb3.Text = so3.ToString();
            if(rd3.Checked)
            {
                if ((so1 + so2 + so3) <= 10)
                    diem += 10;
                else
                {
                    if (diem == 0)
                        diem = 0;
                    else diem -= 10;
                }
            }
            else if (rd11.Checked)
            {
                if ((so1 + so2 + so3) >= 11 && (so1 + so2 + so3) <= 18)
                    diem +=10;
                else
                {
                    if (diem == 0)
                        diem = 0;
                    else diem -= 10;
                }
            }
            lbDiem.Text=diem.ToString();
        }
    }
}
