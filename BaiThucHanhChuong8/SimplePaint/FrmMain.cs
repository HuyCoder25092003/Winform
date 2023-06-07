using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDrawText_Click(object sender, EventArgs e)
        {
            FrmDrawText f =new SimplePaint.FrmDrawText();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawImage_Click(object sender, EventArgs e)
        {
            FrmDwamImage f = new SimplePaint.FrmDwamImage();
            f.MdiParent = this;
            f.Show();
        }

        private void menuDrawByMouse_Click(object sender, EventArgs e)
        {
            FrmDrawByMouse f = new SimplePaint.FrmDrawByMouse();
            f.MdiParent = this;
            f.Show();
        }
    }
}
