namespace RandomNumber
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.btQuaySo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(92, 35);
            this.lb1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(124, 120);
            this.lb1.TabIndex = 0;
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            this.lb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(354, 35);
            this.lb2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(124, 120);
            this.lb2.TabIndex = 0;
            this.lb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb3
            // 
            this.lb3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(607, 35);
            this.lb3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(124, 120);
            this.lb3.TabIndex = 0;
            this.lb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd11);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(88, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 130);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rd11
            // 
            this.rd11.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd11.AutoSize = true;
            this.rd11.ForeColor = System.Drawing.Color.Red;
            this.rd11.Location = new System.Drawing.Point(396, 44);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(110, 48);
            this.rd11.TabIndex = 0;
            this.rd11.Text = "11-18";
            this.rd11.UseVisualStyleBackColor = true;
            // 
            // rd3
            // 
            this.rd3.Appearance = System.Windows.Forms.Appearance.Button;
            this.rd3.AutoSize = true;
            this.rd3.Checked = true;
            this.rd3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd3.ForeColor = System.Drawing.Color.Red;
            this.rd3.Location = new System.Drawing.Point(149, 44);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(96, 48);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "3-10";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // btQuaySo
            // 
            this.btQuaySo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btQuaySo.ForeColor = System.Drawing.Color.Blue;
            this.btQuaySo.Location = new System.Drawing.Point(134, 348);
            this.btQuaySo.Name = "btQuaySo";
            this.btQuaySo.Size = new System.Drawing.Size(167, 69);
            this.btQuaySo.TabIndex = 2;
            this.btQuaySo.Text = "Quay số";
            this.btQuaySo.UseVisualStyleBackColor = false;
            this.btQuaySo.Click += new System.EventHandler(this.btQuaySo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbDiem
            // 
            this.lbDiem.AutoSize = true;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.ForeColor = System.Drawing.Color.Red;
            this.lbDiem.Location = new System.Drawing.Point(602, 348);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(84, 91);
            this.lbDiem.TabIndex = 4;
            this.lbDiem.Text = "0";
            this.lbDiem.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(823, 447);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQuaySo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.Button btQuaySo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbDiem;
    }
}

