namespace RandomNumber1
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
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.Silver;
            this.lb1.ForeColor = System.Drawing.Color.Blue;
            this.lb1.Location = new System.Drawing.Point(100, 44);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(116, 115);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "0";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.Silver;
            this.lb2.ForeColor = System.Drawing.Color.Blue;
            this.lb2.Location = new System.Drawing.Point(303, 44);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(116, 115);
            this.lb2.TabIndex = 0;
            this.lb2.Text = "0";
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.Silver;
            this.lb3.ForeColor = System.Drawing.Color.Blue;
            this.lb3.Location = new System.Drawing.Point(506, 44);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(116, 115);
            this.lb3.TabIndex = 0;
            this.lb3.Text = "0";
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(107, 270);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(515, 49);
            this.lbResult.TabIndex = 1;
            this.lbResult.Text = "0";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btPlay.ForeColor = System.Drawing.Color.Blue;
            this.btPlay.Location = new System.Drawing.Point(151, 376);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(149, 48);
            this.btPlay.TabIndex = 2;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.SystemColors.Control;
            this.btClose.ForeColor = System.Drawing.Color.Blue;
            this.btClose.Location = new System.Drawing.Point(423, 376);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(149, 48);
            this.btClose.TabIndex = 2;
            this.btClose.Text = "Exit";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 460);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RandomNumber";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Button btClose;
    }
}

