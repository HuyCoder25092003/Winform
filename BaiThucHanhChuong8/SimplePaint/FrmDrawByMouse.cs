using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace SimplePaint
{
    public partial class FrmDrawByMouse : Form
    {
        Color color; // màu nét vẽ
        int pentWidth; // độ dày né vẽ
        Point pOld; // điểm lưu vị trí điểm nhấn chuột
        Bitmap bmp;//vẽ trên bitmap nayu2 sau đó mới vẽ form
        public FrmDrawByMouse()
        {
            InitializeComponent();
        }

        private void FrmDrawByMouse_Load(object sender, EventArgs e)
        {
            color = Color.Red;
            pentWidth = 1;
            //bmp có kích thuốc = màn hình kíc thước
            bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

        }

        private void FrmDrawByMouse_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void FrmDrawByMouse_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Pen pen = new Pen(color, pentWidth);
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                Graphics g = Graphics.FromImage(bmp);
                g.DrawLine(pen, pOld, e.Location);
                pOld = e.Location;
                Invalidate(); 
            }
        }

        private void FrmDrawByMouse_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bmp,0,0);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch(keyData)
            {
                case Keys.R: color = Color.Red; break;
                case Keys.G: color = Color.Green; break;
                case Keys.B:color= Color.Blue; break;
                case Keys.Up:pentWidth++;break;
                case Keys.Down:pentWidth--;break;
            }
            return true;
        }
    }
}
