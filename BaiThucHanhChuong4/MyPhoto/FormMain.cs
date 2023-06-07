﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoto
{
    public partial class FormMain : Form
    {
        public static int Count = 1;
        public FormMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        void LoadForm()
        {
            FormSub fSub = new FormSub();
            fSub.LayoutMdi(MdiLayout.Cascade);
            fSub.MdiParent = this;
            fSub.Text = string.Format("Photo {0}", Count++);
            fSub.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận tắt chương trình?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void TsmNew_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void TsmCloseAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận tắt tất cả form?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form f in MdiChildren)
                    f.Close();
                Count = 1;
            }
        }
        private void TsmExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TsmCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TsmTileH_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TsmTileV_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
