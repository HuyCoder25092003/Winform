﻿using System;
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
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        { 
            Font f =new Font("Arial",36,FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello",f,Brushes.Green,ClientRectangle,format);

            TextureBrush tbr = new TextureBrush(Image.FromFile("hoa.png"));
            format.Alignment= StringAlignment.Near;
            format.LineAlignment= StringAlignment.Far;
            e.Graphics.DrawString("Hello", f, tbr, ClientRectangle, format);

            HatchBrush hbr = new HatchBrush(HatchStyle.DarkHorizontal,Color.Orange,Color.Yellow);
            format.FormatFlags = StringFormatFlags.DirectionVertical;
            format.LineAlignment = StringAlignment.Near;
            e.Graphics.DrawString("Hello", f, hbr, ClientRectangle, format);

            LinearGradientBrush lbr = new LinearGradientBrush(new Rectangle(50, 50, 10, 10), Color.Blue, Color.White, 45);
            format.Alignment = StringAlignment.Far;
            format.LineAlignment = StringAlignment.Far;
            e.Graphics.DrawString("Hello", f, lbr, ClientRectangle, format);
        }

        private void FrmDrawText_SizeChanged(object sender, EventArgs e)
        {
            Invalidate(); //gọi hàm paint 
        }
    }
}
