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
namespace PhotoAlbum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitTree();
        }

        void InitTree()
        {
            string[] arrDrive = Directory.GetLogicalDrives();
            TreeNode node = null;
            foreach(string drive in arrDrive)
            {
                node = new TreeNode(drive);
                node.ImageIndex = 0;
                node.Nodes.Add("tmp");
                treeFolder.Nodes.Add(node);
            }
        }

        private void treeFolder_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            try
            {
                string[] arrDrive = Directory.GetDirectories(e.Node.FullPath);
                TreeNode node = null;
                foreach (string drive in arrDrive)
                {
                    node = new TreeNode(drive);
                    node.ImageIndex = 0;
                    node.Nodes.Add("tmp");
                    e.Node.Nodes.Add(node);
                }
            }
            catch
            {

            }
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                pnThum.Controls.Clear();
                picView.Image = null;
                string[] arrFile = Directory.GetFiles(e.Node.FullPath);
                foreach(string file in arrFile)
                {
                    if (file.ToLower().EndsWith(".jpg")||
                        file.ToLower().EndsWith(".png")||
                        file.ToLower().EndsWith(".bmp")||
                        file.ToLower().EndsWith(".gif"))
                    {
                        PictureBox pic = new PictureBox();
                        pic.Image = Image.FromFile(file);
                        pic.SizeMode = PictureBoxSizeMode.Zoom;
                        pic.Height = pnThum.Height - 10;
                        pic.Width = 5 * pic.Height / 4;
                        pic.Cursor = Cursors.Hand;
                        pic.Click += Pic_Click;
                        pnThum.Controls.Add(pic);
                    }
                }

            }
            catch
            {

            }
        }

        private void Pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picView.Image = pic.Image;
        }

        private void treeFolder_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void treeFolder_AfterCollapse(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }
    }
}
