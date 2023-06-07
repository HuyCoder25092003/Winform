using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MoveObject
{
    public partial class Form1 : Form
    {
        int count;
        Point pOld; // biến lưu vị trí nhấn chuột
        Random r = new Random();
        string[] arrFile;
        int imgWidth = 90;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Dùng chuột hoặc các phím mũi tên di chuyển hình vào khung";
            arrFile = Directory.GetFiles(Application.StartupPath + @"\Images");
            AddNewPicture();
        }

        void AddNewPicture()
        {
            count++;
            string file = arrFile[r.Next(arrFile.Length)];
            Image img = Image.FromFile(file);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = count.ToString();
            pictureBox.Image = img;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Width = pictureBox.Height = imgWidth;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox.MouseDown += PictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp   += PictureBox_MouseUp;

            this.Controls.Add(pictureBox);

            this.Controls.SetChildIndex(pnBound, this.Controls.Count-1);
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if(pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddNewPicture();
            }
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PictureBox pic = (PictureBox)sender;
                int dx = e.X - pOld.X;
                int dy = e.Y - pOld.Y;
                pic.Left += dx;
                pic.Top += dy;

            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            pOld = e.Location;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Control[] arrControl = this.Controls.Find(count.ToString(),false);
            PictureBox pic = (PictureBox)arrControl[0];
            switch(e.KeyCode)
            {
                case Keys.Left:
                    if (pic.Left -5  > 0)
                        pic.Left-=5;
                    break;
                case Keys.Right:
                    if (pic.Right+5 < ClientRectangle.Width)
                        pic.Left+=5;
                    break;
                case Keys.Up:
                    if(pic.Top -5  <0)
                        pic.Top-=5;
                    break;
                case Keys.Down:
                    if(pic.Bottom + 5 < ClientRectangle.Height)
                        pic.Top+=5;
                    break;
            }

            if(pnBound.Bounds.Contains(pic.Bounds))
            {
                pnBound.Controls.Add(pic);
                AddNewPicture();
            }

        }

        private void pnBound_MouseDown(object sender, MouseEventArgs e)
        {
            pOld =e.Location;
        }

        private void pnBound_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                pnBound.Left += e.X - pOld.X;
                pnBound.Top += e.Y - pOld.Y;
            }
        }
    }
}
