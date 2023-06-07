using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeHinh
{
    public partial class Options : Form
    {
        private List<RadioButton> radioButtons;
        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load(object sender, EventArgs e)
        {
            radioButtons = groupBox1.Controls.OfType<RadioButton>().ToList();
            lbColor.BackColor = Form1.shapeColor;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Text == Form1.shapeType)
                {
                    radioButton.Checked = true;
                    break;
                }
            }
        }

        private void LbColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog
            {
                AllowFullOpen = true,
                FullOpen = true
            };
            if (dlg.ShowDialog() == DialogResult.OK) lbColor.BackColor = dlg.Color;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Form1.shapeColor = lbColor.BackColor;
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    Form1.shapeType = radioButton.Text;
                    break;
                }
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
