using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoto
{
    public partial class FormSub : Form
    {
        public FormSub()
        {
            InitializeComponent();
        }

        void LoadImage(string path)
        {
            if (path == null)
            {
                picImage.Image = null;
                return;
            }
            picImage.Image = Image.FromFile(path);
        }

        private void FormSub_Load(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\Plastic\1.jpg");
        }

        private void TsmLoad_Click(object sender, EventArgs e)
        {
            LoadImage(Application.StartupPath + @"\Plastic\1.jpg");
        }

        private void TsmOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All files |*.png;*.jpg;*.bmp;*.gif|"
                + "PNG |*.png|" + "JPEG |*.jpg|" + "BMP |*.bmp|" + "GIF |*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                LoadImage(ofd.FileName);
            }
        }

        private void TsmClear_Click(object sender, EventArgs e)
        {
            LoadImage(null);
        }

        private void TsmSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG |*.png|" + "JPEG |*.jpg|" + "BMP |*.bmp|" + "GIF |*.gif";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string ex = Path.GetExtension(sfd.FileName);
                switch (ex)
                {
                    case ".png": picImage.Image.Save(sfd.FileName, ImageFormat.Png); break;
                    case ".jpg": picImage.Image.Save(sfd.FileName, ImageFormat.Jpeg); break;
                    case ".bmp": picImage.Image.Save(sfd.FileName, ImageFormat.Bmp); break;
                    case ".gif": picImage.Image.Save(sfd.FileName, ImageFormat.Gif); break;
                }
            }
        }

        private void TsmClose_Click(object sender, EventArgs e)
        {
            Close();
            FormMain.Count--;
        }

    }
}
