namespace QuaySo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbName = new System.Windows.Forms.Label();
            this.picSo1 = new System.Windows.Forms.PictureBox();
            this.picSo2 = new System.Windows.Forms.PictureBox();
            this.picSo3 = new System.Windows.Forms.PictureBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btPlay = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Blue;
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(21, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(683, 28);
            this.lbName.TabIndex = 0;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // picSo1
            // 
            this.picSo1.Location = new System.Drawing.Point(38, 75);
            this.picSo1.Name = "picSo1";
            this.picSo1.Size = new System.Drawing.Size(143, 124);
            this.picSo1.TabIndex = 1;
            this.picSo1.TabStop = false;
            // 
            // picSo2
            // 
            this.picSo2.Location = new System.Drawing.Point(291, 75);
            this.picSo2.Name = "picSo2";
            this.picSo2.Size = new System.Drawing.Size(143, 124);
            this.picSo2.TabIndex = 1;
            this.picSo2.TabStop = false;
            // 
            // picSo3
            // 
            this.picSo3.Location = new System.Drawing.Point(544, 75);
            this.picSo3.Name = "picSo3";
            this.picSo3.Size = new System.Drawing.Size(143, 124);
            this.picSo3.TabIndex = 1;
            this.picSo3.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.BackColor = System.Drawing.Color.Blue;
            this.lbResult.ForeColor = System.Drawing.Color.White;
            this.lbResult.Location = new System.Drawing.Point(251, 288);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(222, 36);
            this.lbResult.TabIndex = 2;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btClose
            // 
            this.btClose.ForeColor = System.Drawing.Color.Blue;
            this.btClose.Location = new System.Drawing.Point(434, 362);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(156, 56);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Đóng";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btPlay
            // 
            this.btPlay.ForeColor = System.Drawing.Color.Blue;
            this.btPlay.Location = new System.Drawing.Point(134, 362);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(156, 56);
            this.btPlay.TabIndex = 3;
            this.btPlay.Text = "Quay số";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 471);
            this.Controls.Add(this.btPlay);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.picSo3);
            this.Controls.Add(this.picSo2);
            this.Controls.Add(this.picSo1);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSo3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox picSo1;
        private System.Windows.Forms.PictureBox picSo2;
        private System.Windows.Forms.PictureBox picSo3;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Timer timer1;
    }
}

