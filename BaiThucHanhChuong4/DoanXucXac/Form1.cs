using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanXucXac
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        string path;
        int nCount, nLose, nWin, nChoose;
        string kq ="Thua";
        void Init()
        {
            path = Application.StartupPath + @"\HinhXucxac\";
            nChoose = 1;
            nWin = nLose = nCount = 0;
            picChoose.Image = Image.FromFile(path + "1.bmp");
            picResult.Image = null;
            lbCount.Text = lbLose.Text = lbWin.Text = "";
            listResult.Items.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }
        void Play()
        {
            int n = r.Next(1, 7);
            picResult.Image = Image.FromFile(path + n.ToString() + ".bmp");
            nCount++;
            if (nChoose == n)
            {
                kq = "Thắng";
                nWin++;
            }
            else
            {
                kq = "Thua";
                nLose++;
            }
            lbCount.Text = String.Format("Lần đoán {0}", nCount);
            lbWin.Text = String.Format("Lần thắng: {0} ({1:0.00})", nWin, (double)nWin * 100 / nCount);
            lbLose.Text = String.Format("Lần thua: {0} ({1:0.00})", nLose, (double)nLose * 100 / nCount);
            listResult.Items.Add(String.Format("{0}. {1} (Đoán {2} ra {3})",nCount,kq, nChoose, n));
        }
        private void btPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt =(Button)sender;
            nChoose = int.Parse(bt.Text);
            picChoose.Image = Image.FromFile(path+nChoose.ToString()+".bmp");
        }

        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:Play(); break;
                case Keys.Escape:Init(); break;
            }
            return false;
        }
    }
}
