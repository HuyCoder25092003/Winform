using BallGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGame
{
    public partial class Form1 : Form
    {
        private Point pOldPointCR, pDefaultPointBall, pDefaultPointCR;
        private int moveStepX = 5;
        private int moveStepY = 7;
        private int scores = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pcBall.Image = Resources.pngwing_com;
            pDefaultPointBall = pcBall.Location;
            pDefaultPointCR = lbCrossBar.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.S: timerBall.Enabled = !timerBall.Enabled; break;
                case Keys.Left: if (lbCrossBar.Left - 5 > 0) lbCrossBar.Left -= 20; break;
                case Keys.Right: if (lbCrossBar.Right < ClientRectangle.Width - 5) lbCrossBar.Left += 20; break;
            }
        }

        private void timerBall_Tick(object sender, EventArgs e)
        {
            if (pcBall.Left < 0 || pcBall.Right > ClientRectangle.Width) moveStepX = -moveStepX;

            bool ballHitCrossBar = pcBall.Bounds.IntersectsWith(lbCrossBar.Bounds);
            if (pcBall.Top < 0 || ballHitCrossBar)
            {
                moveStepY = -moveStepY;
                if (ballHitCrossBar) scores++;
            }

            pcBall.Left += moveStepX;
            pcBall.Top += moveStepY;
            if (pcBall.Bottom > lbCrossBar.Bottom)
            {
                timerBall.Stop();
                if (MessageBox.Show(string.Format("Điểm số của bạn là {0}. Bạn có muốn chơi lại?", scores), "Xác nhận",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                scores = 0;
                pcBall.Location = pDefaultPointBall;
                lbCrossBar.Location = pDefaultPointCR;
            }
        }

        private void LbCrossBar_MouseDown(object sender, MouseEventArgs e)
        {
            pOldPointCR = e.Location;
        }


        private void lbCrossBar_MouseMove(object sender, MouseEventArgs e)
        {
            Label lbCrossBar = sender as Label;
            int dx = e.X - pOldPointCR.X;
            if (e.Button == MouseButtons.Left &&
                lbCrossBar.Left + dx - 5 > 0 &&
                lbCrossBar.Right + dx + 5 < ClientRectangle.Width)
            {
                lbCrossBar.Left += dx;
            }
        }

    }
}
