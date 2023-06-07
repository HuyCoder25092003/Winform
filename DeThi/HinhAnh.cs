using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeThi
{
    public partial class HinhAnh : Form
    {
        int xPos = 0;
        public HinhAnh()
        {
            InitializeComponent();
        }

        private void HinhAnh_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rc1 = new Rectangle(ClientRectangle.Left, ClientRectangle.Top, ClientRectangle.Width, ClientRectangle.Height / 2);
            Rectangle rc2 = new Rectangle(ClientRectangle.Left, rc1.Bottom, ClientRectangle.Width, ClientRectangle.Height / 2);
            DrawImage(rc1, e.Graphics);
            DrawText(rc2, e.Graphics);


            Rectangle[] arrRect = { rc1, rc2 };

        }
        void DrawImage(Rectangle rc, Graphics g)
        {
            Image img = Image.FromFile("messi.jpg");
            g.DrawImage(img, rc);
            Color c = Color.FromArgb(100, 255, 255, 0);
        }
        void DrawText(Rectangle rc, Graphics g)
        {
            LinearGradientBrush br = new LinearGradientBrush(rc, Color.Orange, Color.White, 45);
            g.FillRectangle(br, rc);
            SolidBrush lbr = new SolidBrush(Color.Red);
            StringFormat fm = new StringFormat();
            fm.Alignment = StringAlignment.Center;
            fm.LineAlignment = StringAlignment.Center;
            Font f = new Font("Arial", 48, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("MESSI", f, lbr, rc, fm);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xPos += 10;

            // Kiểm tra nếu dòng chữ vượt quá chiều rộng của form thì đưa nó về vị trí ban đầu
            if (xPos > this.Width)
            {
                xPos = 0;
            }

            // Vẽ lại dòng chữ với vị trí mới
            this.Invalidate();
        }
    }
}
