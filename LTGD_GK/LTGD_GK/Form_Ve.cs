using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace LTGD_GK
{
    public partial class Form_Ve : Form
    {
        public Form_Ve()
        {
            InitializeComponent();
        }

        private void Form_Ve_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect1 = new Rectangle(0, 0,
                ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rect2 = new Rectangle(ClientRectangle.Width / 2, 0,
                ClientRectangle.Width / 2, ClientRectangle.Height / 2);
            Rectangle rect3 = new Rectangle(0, ClientRectangle.Height / 2,
                ClientRectangle.Width, ClientRectangle.Height / 2);
            e.Graphics.DrawRectangles(Pens.Red, new Rectangle[] { rect1, rect2, rect3 });

            // Copy cái hình vào thư mục debug của project. Tao làm tượng trưng chỗ này thôi
            Image img1 = Image.FromFile("hinh.png");
            Image img2 = Image.FromFile("hinh.png");
            // Tự xoay hình theo đúng đề bài đi. Ghi y chang t, sửa img1 hoặc img2 cho đúng thôi
            img2.RotateFlip(RotateFlipType.RotateNoneFlipX);
            e.Graphics.DrawImage(img1, rect1);
            e.Graphics.DrawImage(img2, rect2);

            HatchBrush hatchBrush = new HatchBrush(HatchStyle.LargeGrid, Color.Red, Color.Orange);
            e.Graphics.FillRectangle(hatchBrush, rect3);


            Font font = new Font("Arial", 60, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;
            format.LineAlignment = StringAlignment.Center;
            // Vẽ chữ với bóng gradient phía sau
            GraphicsPath path = new GraphicsPath();
            path.AddString("MESSI", font.FontFamily, (int)font.Style, font.Size, rect3, format);

            PointF centerPoint = new PointF(rect3.Left + path.GetBounds().Width / 2f, rect3.Top + rect3.Height / 2f);
            PathGradientBrush brush = new PathGradientBrush(path);
            brush.CenterPoint = centerPoint;
            brush.CenterColor = Color.FromArgb(0, 0, 0, 0);
            brush.SurroundColors = new Color[] { Color.FromArgb(128, 0, 0, 0) };
            e.Graphics.FillPath(brush, path);

            // Vẽ chữ
            SolidBrush textBrush = new SolidBrush(Color.Blue);
            e.Graphics.DrawString("MESSI", font, textBrush, rect3, format);

        }

        private void Form_Ve_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
