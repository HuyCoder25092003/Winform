namespace BallGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pcBall = new System.Windows.Forms.PictureBox();
            this.lbCrossBar = new System.Windows.Forms.Label();
            this.timerBall = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pcBall
            // 
            this.pcBall.ErrorImage = null;
            this.pcBall.Location = new System.Drawing.Point(263, 12);
            this.pcBall.Name = "pcBall";
            this.pcBall.Size = new System.Drawing.Size(136, 116);
            this.pcBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBall.TabIndex = 0;
            this.pcBall.TabStop = false;
            // 
            // lbCrossBar
            // 
            this.lbCrossBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbCrossBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbCrossBar.Location = new System.Drawing.Point(249, 378);
            this.lbCrossBar.Name = "lbCrossBar";
            this.lbCrossBar.Size = new System.Drawing.Size(166, 19);
            this.lbCrossBar.TabIndex = 3;
            this.lbCrossBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCrossBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LbCrossBar_MouseDown);
            this.lbCrossBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbCrossBar_MouseMove);
            // 
            // timerBall
            // 
            this.timerBall.Interval = 20;
            this.timerBall.Tick += new System.EventHandler(this.timerBall_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCrossBar);
            this.Controls.Add(this.pcBall);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcBall;
        private System.Windows.Forms.Label lbCrossBar;
        private System.Windows.Forms.Timer timerBall;
    }
}

