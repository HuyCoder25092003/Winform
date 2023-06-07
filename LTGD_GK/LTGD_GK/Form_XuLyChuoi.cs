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
    public partial class Form_XuLyChuoi : Form
    {
        public Form_XuLyChuoi()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtChuoi.Text))
            {
                if (rdChenCuoi.Checked)
                {
                    listBox1.Items.Add(txtChuoi.Text);
                }
                if (rdChenDau.Checked)
                {
                    listBox1.Items.Insert(0, txtChuoi.Text);
                }
                txtChuoi.Text = "";
                txtChuoi.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                listBox2.Font = fd.Font;
            }
        }

        private void btnMau_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.AllowFullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                listBox2.ForeColor = cd.Color;
            }
        }

        private void btnDaoChuoi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string str = listBox2.Items[i].ToString();
                string[] arrStr = str.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Reverse(arrStr);
                str = String.Join(" ", arrStr);
                listBox2.Items.RemoveAt(i);
                listBox2.Items.Insert(i, str);
            }
        }

        private void btnChuanHoa_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                string str = listBox2.Items[i].ToString().Trim();
                string[] arrStr = str.Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < arrStr.Length; j++)
                {
                    arrStr[j] = arrStr[j].Substring(0, 1).ToUpper() + arrStr[j].Substring(1).ToLower();
                }
                str = String.Join(" ", arrStr);
                listBox2.Items.RemoveAt(i);
                listBox2.Items.Insert(i, str);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
                listBox2.Items.Add(listBox1.SelectedItem);
        }
    }
}
