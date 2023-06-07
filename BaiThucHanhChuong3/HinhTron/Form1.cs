using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HinhTron
{
    public partial class Form1 : Form
    {
        Circle circle = new Circle();
        Diem point = new Diem();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnXemKQ_Click(object sender, EventArgs e)
        {
            try
            {
                double cDx = Convert.ToDouble(txtCenterX.Text);
                double cDy = Convert.ToDouble(txtCenterY.Text);
                double cRadius = Convert.ToDouble(txtRadius.Text);
                double oDx = Convert.ToDouble(txtOtherX.Text);
                double oDy = Convert.ToDouble(txtOtherY.Text);
                circle.Center = new Diem(cDx, cDy);
                circle.Radius = cRadius;
                point.X = oDx;
                point.Y = oDy;
                lbArea.Text = string.Format("Diện tích: {0:0.##}", circle.DienTich());
                lbPerimeter.Text = string.Format("Chu vi: {0:0.##}", circle.ChuVi());
                lbResult.Text = circle.Check(point) ? "Nằm trên hình tròn" : "Không nằm trên hình tròn";
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập các thông tin trước khi xem!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
