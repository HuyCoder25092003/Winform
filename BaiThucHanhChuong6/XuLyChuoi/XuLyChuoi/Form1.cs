using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyChuoi
{
    public partial class Form1 : Form
    {
        string text = "Khoa  Công  nghệ  thông  tin,  đại học  MỞ  THÀNH  PHỐ  HỒ   CHÍ  MINH";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTieuDe.Text = "    CHƯƠNG TRÌNH MINH HỌA XỬ LÝ CHUỖI";
            txtString1.Text = text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTieuDe.Text = lbTieuDe.Text.Substring(lbTieuDe.Text.Length - 1) + lbTieuDe.Text.Substring(0, lbTieuDe.Text.Length - 1);
        }

        private void btThayThe_Click(object sender, EventArgs e)
        {
            //txtString1.Text = txtString1.Text.ToLower().Replace(txtString2.Text, txtString3.Text);
            string s1 = txtString1.Text.ToLower();
            string s2 = txtString2.Text.ToLower();
            int index = s1.IndexOf(s2);
            while (index >= 0)
            {
                s1 = s1.Remove(index, s2.Length);
                s1 = s1.Insert(index, txtString3.Text);
                txtString1.Text = txtString1.Text.Remove(index, s2.Length);
                txtString1.Text = txtString1.Text.Insert(index, txtString3.Text);
                index = s1.IndexOf(s2);
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            string s1 = txtString1.Text.ToLower();
            string s2 = txtString2.Text.ToLower();
            int index = s1.IndexOf(s2);
            while (index >= 0)
            {
                s1 = s1.Remove(index, s2.Length);
                txtString1.Text = txtString1.Text.Remove(index, s2.Length);
                index = s1.IndexOf(s2);
            }
        }
        private void btDao_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtString1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(arr);
            txtString1.Text = String.Join(" ",arr);
        }

        private void btChen_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtChen.Text);
            if (pos < 0 || pos > txtChen.Text.Length)
                return;
            txtString1.Text = txtString1.Text.Insert(pos, txtString2.Text);
        }

        private void btLayChuoiCon_Click(object sender, EventArgs e)
        {
            int pos = int.Parse(txtStartPos.Text);
            if (pos < 0 || pos > txtString1.Text.Length)
                return;
            int number = int.Parse(txtNumber.Text);
            if (number < 0 || number > txtString1.Text.Length)
                return;
            txtString2.Text = txtString1.Text.Substring(pos,number);
        }

        private void btKhoiPhuc_Click(object sender, EventArgs e)
        {
            txtString1.Text = text;
        }

        private void btChuanHoa_Click(object sender, EventArgs e)
        {
            char[] token = { ' ', '\t' };
            string[] arr = txtString1.Text.Split(token, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < arr.Length; i++)
                arr[i] = arr[i].Substring(0, 1).ToUpper() + arr[i].Substring(1).ToLower();
            txtString1.Text = String.Join(" ", arr);
        }
    }
}
