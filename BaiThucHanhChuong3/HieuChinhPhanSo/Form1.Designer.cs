namespace HieuChinhPhanSo
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
            this.lbName = new System.Windows.Forms.Label();
            this.txtTu1 = new System.Windows.Forms.TextBox();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnXemDA = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.pnlKetQua = new System.Windows.Forms.Panel();
            this.txtMau3 = new System.Windows.Forms.TextBox();
            this.txtTu3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlPhanSo2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMau2 = new System.Windows.Forms.TextBox();
            this.txtTu2 = new System.Windows.Forms.TextBox();
            this.pnlPhanSo1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMau1 = new System.Windows.Forms.TextBox();
            this.txtTuSo1 = new System.Windows.Forms.TextBox();
            this.lbBang = new System.Windows.Forms.Label();
            this.lbToanTu = new System.Windows.Forms.Label();
            this.pnlKetQua.SuspendLayout();
            this.pnlPhanSo2.SuspendLayout();
            this.pnlPhanSo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Blue;
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(800, 129);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "CÁC PHÉP TÍNH TRÊN PHÂN SỐ";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTu1
            // 
            this.txtTu1.Location = new System.Drawing.Point(28, 45);
            this.txtTu1.Name = "txtTu1";
            this.txtTu1.Size = new System.Drawing.Size(100, 22);
            this.txtTu1.TabIndex = 11;
            this.txtTu1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDatLai
            // 
            this.btnDatLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLai.ForeColor = System.Drawing.Color.Blue;
            this.btnDatLai.Location = new System.Drawing.Point(295, 372);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(248, 50);
            this.btnDatLai.TabIndex = 18;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.UseVisualStyleBackColor = true;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.ForeColor = System.Drawing.Color.Blue;
            this.btnRandom.Location = new System.Drawing.Point(53, 316);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(226, 50);
            this.btnRandom.TabIndex = 19;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnXemDA
            // 
            this.btnXemDA.Enabled = false;
            this.btnXemDA.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDA.ForeColor = System.Drawing.Color.Blue;
            this.btnXemDA.Location = new System.Drawing.Point(559, 316);
            this.btnXemDA.Name = "btnXemDA";
            this.btnXemDA.Size = new System.Drawing.Size(228, 50);
            this.btnXemDA.TabIndex = 21;
            this.btnXemDA.Text = "Xem đáp án";
            this.btnXemDA.UseVisualStyleBackColor = true;
            this.btnXemDA.Click += new System.EventHandler(this.btnXemDA_Click);
            // 
            // btnChia
            // 
            this.btnChia.ForeColor = System.Drawing.Color.Blue;
            this.btnChia.Location = new System.Drawing.Point(493, 316);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(50, 50);
            this.btnChia.TabIndex = 17;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.ForeColor = System.Drawing.Color.Blue;
            this.btnNhan.Location = new System.Drawing.Point(427, 316);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(50, 50);
            this.btnNhan.TabIndex = 16;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.ForeColor = System.Drawing.Color.Blue;
            this.btnTru.Location = new System.Drawing.Point(361, 316);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(50, 50);
            this.btnTru.TabIndex = 15;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnCong
            // 
            this.btnCong.ForeColor = System.Drawing.Color.Blue;
            this.btnCong.Location = new System.Drawing.Point(295, 316);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(50, 50);
            this.btnCong.TabIndex = 12;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // pnlKetQua
            // 
            this.pnlKetQua.AutoSize = true;
            this.pnlKetQua.Controls.Add(this.txtMau3);
            this.pnlKetQua.Controls.Add(this.txtTu3);
            this.pnlKetQua.Controls.Add(this.label4);
            this.pnlKetQua.Enabled = false;
            this.pnlKetQua.Location = new System.Drawing.Point(631, 151);
            this.pnlKetQua.Name = "pnlKetQua";
            this.pnlKetQua.Size = new System.Drawing.Size(156, 149);
            this.pnlKetQua.TabIndex = 24;
            // 
            // txtMau3
            // 
            this.txtMau3.Location = new System.Drawing.Point(28, 89);
            this.txtMau3.Name = "txtMau3";
            this.txtMau3.Size = new System.Drawing.Size(100, 22);
            this.txtMau3.TabIndex = 1;
            this.txtMau3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTu3
            // 
            this.txtTu3.Location = new System.Drawing.Point(28, 17);
            this.txtTu3.Name = "txtTu3";
            this.txtTu3.Size = new System.Drawing.Size(100, 22);
            this.txtTu3.TabIndex = 0;
            this.txtTu3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(28, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 10);
            this.label4.TabIndex = 6;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPhanSo2
            // 
            this.pnlPhanSo2.AutoSize = true;
            this.pnlPhanSo2.Controls.Add(this.label3);
            this.pnlPhanSo2.Controls.Add(this.txtMau2);
            this.pnlPhanSo2.Controls.Add(this.txtTu2);
            this.pnlPhanSo2.Location = new System.Drawing.Point(346, 151);
            this.pnlPhanSo2.Name = "pnlPhanSo2";
            this.pnlPhanSo2.Size = new System.Drawing.Size(156, 149);
            this.pnlPhanSo2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(28, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 10);
            this.label3.TabIndex = 6;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMau2
            // 
            this.txtMau2.Location = new System.Drawing.Point(28, 88);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.Size = new System.Drawing.Size(100, 22);
            this.txtMau2.TabIndex = 5;
            this.txtMau2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTu2
            // 
            this.txtTu2.Location = new System.Drawing.Point(28, 16);
            this.txtTu2.Name = "txtTu2";
            this.txtTu2.Size = new System.Drawing.Size(100, 22);
            this.txtTu2.TabIndex = 0;
            this.txtTu2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlPhanSo1
            // 
            this.pnlPhanSo1.AutoSize = true;
            this.pnlPhanSo1.Controls.Add(this.label2);
            this.pnlPhanSo1.Controls.Add(this.txtMau1);
            this.pnlPhanSo1.Controls.Add(this.txtTuSo1);
            this.pnlPhanSo1.Location = new System.Drawing.Point(53, 151);
            this.pnlPhanSo1.Name = "pnlPhanSo1";
            this.pnlPhanSo1.Size = new System.Drawing.Size(156, 149);
            this.pnlPhanSo1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 10);
            this.label2.TabIndex = 6;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMau1
            // 
            this.txtMau1.Location = new System.Drawing.Point(28, 88);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.Size = new System.Drawing.Size(100, 22);
            this.txtMau1.TabIndex = 1;
            this.txtMau1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTuSo1
            // 
            this.txtTuSo1.Location = new System.Drawing.Point(28, 16);
            this.txtTuSo1.Name = "txtTuSo1";
            this.txtTuSo1.Size = new System.Drawing.Size(100, 22);
            this.txtTuSo1.TabIndex = 0;
            this.txtTuSo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbBang
            // 
            this.lbBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBang.ForeColor = System.Drawing.Color.Blue;
            this.lbBang.Location = new System.Drawing.Point(508, 176);
            this.lbBang.Name = "lbBang";
            this.lbBang.Size = new System.Drawing.Size(121, 117);
            this.lbBang.TabIndex = 25;
            this.lbBang.Text = "...";
            this.lbBang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbToanTu
            // 
            this.lbToanTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToanTu.ForeColor = System.Drawing.Color.Blue;
            this.lbToanTu.Location = new System.Drawing.Point(219, 174);
            this.lbToanTu.Name = "lbToanTu";
            this.lbToanTu.Size = new System.Drawing.Size(121, 117);
            this.lbToanTu.TabIndex = 26;
            this.lbToanTu.Text = "...";
            this.lbToanTu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBang);
            this.Controls.Add(this.lbToanTu);
            this.Controls.Add(this.pnlKetQua);
            this.Controls.Add(this.pnlPhanSo2);
            this.Controls.Add(this.pnlPhanSo1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtTu1);
            this.Controls.Add(this.btnDatLai);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnXemDA);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlKetQua.ResumeLayout(false);
            this.pnlKetQua.PerformLayout();
            this.pnlPhanSo2.ResumeLayout(false);
            this.pnlPhanSo2.PerformLayout();
            this.pnlPhanSo1.ResumeLayout(false);
            this.pnlPhanSo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtTu1;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnXemDA;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Panel pnlKetQua;
        private System.Windows.Forms.TextBox txtMau3;
        private System.Windows.Forms.TextBox txtTu3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlPhanSo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMau2;
        private System.Windows.Forms.TextBox txtTu2;
        private System.Windows.Forms.Panel pnlPhanSo1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMau1;
        private System.Windows.Forms.TextBox txtTuSo1;
        private System.Windows.Forms.Label lbBang;
        private System.Windows.Forms.Label lbToanTu;
    }
}

