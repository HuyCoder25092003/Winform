namespace Cacpheptoan
{
    partial class Form2
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
            this.btDong = new System.Windows.Forms.Button();
            this.btTinh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btKetQua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdChiaDu = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdNhan = new System.Windows.Forms.RadioButton();
            this.rdTru = new System.Windows.Forms.RadioButton();
            this.rdCong = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDong
            // 
            this.btDong.BackColor = System.Drawing.Color.Silver;
            this.btDong.Location = new System.Drawing.Point(705, 393);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(121, 48);
            this.btDong.TabIndex = 18;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = false;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // btTinh
            // 
            this.btTinh.Location = new System.Drawing.Point(705, 282);
            this.btTinh.Name = "btTinh";
            this.btTinh.Size = new System.Drawing.Size(121, 48);
            this.btTinh.TabIndex = 17;
            this.btTinh.Text = "Tính";
            this.btTinh.UseVisualStyleBackColor = true;
            this.btTinh.Click += new System.EventHandler(this.btTinh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số thứ 2";
            // 
            // btKetQua
            // 
            this.btKetQua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btKetQua.Location = new System.Drawing.Point(291, 403);
            this.btKetQua.Name = "btKetQua";
            this.btKetQua.Size = new System.Drawing.Size(400, 39);
            this.btKetQua.TabIndex = 12;
            this.btKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kết Quả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Số thứ 1";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(690, 180);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(138, 45);
            this.txt2.TabIndex = 9;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(285, 183);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(138, 45);
            this.txt1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(949, 66);
            this.label1.TabIndex = 8;
            this.label1.Text = "Các phép tính cơ bản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdChiaDu);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.rdNhan);
            this.groupBox1.Controls.Add(this.rdTru);
            this.groupBox1.Controls.Add(this.rdCong);
            this.groupBox1.Location = new System.Drawing.Point(122, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 113);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdChiaDu
            // 
            this.rdChiaDu.AutoSize = true;
            this.rdChiaDu.Location = new System.Drawing.Point(439, 48);
            this.rdChiaDu.Name = "rdChiaDu";
            this.rdChiaDu.Size = new System.Drawing.Size(67, 42);
            this.rdChiaDu.TabIndex = 0;
            this.rdChiaDu.Text = "%";
            this.rdChiaDu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdChiaDu.UseVisualStyleBackColor = true;
            this.rdChiaDu.CheckedChanged += new System.EventHandler(this.rdNhan_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(336, 48);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 42);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "/";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rdNhan_CheckedChanged);
            // 
            // rdNhan
            // 
            this.rdNhan.AutoSize = true;
            this.rdNhan.Location = new System.Drawing.Point(233, 48);
            this.rdNhan.Name = "rdNhan";
            this.rdNhan.Size = new System.Drawing.Size(60, 42);
            this.rdNhan.TabIndex = 0;
            this.rdNhan.Text = "X";
            this.rdNhan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdNhan.UseVisualStyleBackColor = true;
            this.rdNhan.CheckedChanged += new System.EventHandler(this.rdNhan_CheckedChanged);
            // 
            // rdTru
            // 
            this.rdTru.AutoSize = true;
            this.rdTru.Location = new System.Drawing.Point(141, 48);
            this.rdTru.Name = "rdTru";
            this.rdTru.Size = new System.Drawing.Size(49, 42);
            this.rdTru.TabIndex = 0;
            this.rdTru.Text = "-";
            this.rdTru.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTru.UseVisualStyleBackColor = true;
            this.rdTru.CheckedChanged += new System.EventHandler(this.rdTru_CheckedChanged);
            // 
            // rdCong
            // 
            this.rdCong.AutoSize = true;
            this.rdCong.Checked = true;
            this.rdCong.Location = new System.Drawing.Point(41, 48);
            this.rdCong.Name = "rdCong";
            this.rdCong.Size = new System.Drawing.Size(57, 42);
            this.rdCong.TabIndex = 0;
            this.rdCong.TabStop = true;
            this.rdCong.Text = "+";
            this.rdCong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdCong.UseVisualStyleBackColor = true;
            this.rdCong.CheckedChanged += new System.EventHandler(this.rdCong_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(949, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.btTinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2154050099-Huỳnh Thị Thanh Hiền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.Button btTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btKetQua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNhan;
        private System.Windows.Forms.RadioButton rdTru;
        private System.Windows.Forms.RadioButton rdCong;
        private System.Windows.Forms.RadioButton rdChiaDu;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}