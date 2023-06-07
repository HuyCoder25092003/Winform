namespace LTGD_GK
{
    partial class Form_XuLyChuoi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.rdChenDau = new System.Windows.Forms.RadioButton();
            this.rdChenCuoi = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnMau = new System.Windows.Forms.Button();
            this.btnDaoChuoi = new System.Windows.Forms.Button();
            this.btnChuanHoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập chuỗi";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(533, -33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 604);
            this.label3.TabIndex = 1;
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(17, 93);
            this.txtChuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.Size = new System.Drawing.Size(510, 38);
            this.txtChuoi.TabIndex = 0;
            // 
            // rdChenDau
            // 
            this.rdChenDau.AutoSize = true;
            this.rdChenDau.Location = new System.Drawing.Point(10, 184);
            this.rdChenDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdChenDau.Name = "rdChenDau";
            this.rdChenDau.Size = new System.Drawing.Size(349, 36);
            this.rdChenDau.TabIndex = 2;
            this.rdChenDau.TabStop = true;
            this.rdChenDau.Text = "Chèn vào đầu danh sách";
            this.rdChenDau.UseVisualStyleBackColor = true;
            // 
            // rdChenCuoi
            // 
            this.rdChenCuoi.AutoSize = true;
            this.rdChenCuoi.Checked = true;
            this.rdChenCuoi.Location = new System.Drawing.Point(11, 144);
            this.rdChenCuoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdChenCuoi.Name = "rdChenCuoi";
            this.rdChenCuoi.Size = new System.Drawing.Size(354, 36);
            this.rdChenCuoi.TabIndex = 1;
            this.rdChenCuoi.TabStop = true;
            this.rdChenCuoi.Text = "Chèn vào cuối danh sách";
            this.rdChenCuoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(371, 144);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(155, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(371, 184);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(155, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(17, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(509, 314);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Định dạng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chuỗi định dạng";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Location = new System.Drawing.Point(549, 93);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(516, 314);
            this.listBox2.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Định dạng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Chuỗi định dạng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Định dạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(549, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(222, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chuỗi định dạng";
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(644, 429);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(155, 36);
            this.btnFont.TabIndex = 7;
            this.btnFont.Text = "Định dạng font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnMau
            // 
            this.btnMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMau.Location = new System.Drawing.Point(824, 429);
            this.btnMau.Name = "btnMau";
            this.btnMau.Size = new System.Drawing.Size(155, 36);
            this.btnMau.TabIndex = 8;
            this.btnMau.Text = "Định dạng màu";
            this.btnMau.UseVisualStyleBackColor = true;
            this.btnMau.Click += new System.EventHandler(this.btnMau_Click);
            // 
            // btnDaoChuoi
            // 
            this.btnDaoChuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaoChuoi.Location = new System.Drawing.Point(644, 483);
            this.btnDaoChuoi.Name = "btnDaoChuoi";
            this.btnDaoChuoi.Size = new System.Drawing.Size(155, 36);
            this.btnDaoChuoi.TabIndex = 9;
            this.btnDaoChuoi.Text = "Đảo chuỗi";
            this.btnDaoChuoi.UseVisualStyleBackColor = true;
            this.btnDaoChuoi.Click += new System.EventHandler(this.btnDaoChuoi_Click);
            // 
            // btnChuanHoa
            // 
            this.btnChuanHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuanHoa.Location = new System.Drawing.Point(824, 483);
            this.btnChuanHoa.Name = "btnChuanHoa";
            this.btnChuanHoa.Size = new System.Drawing.Size(155, 36);
            this.btnChuanHoa.TabIndex = 10;
            this.btnChuanHoa.Text = "Chuẩn hóa";
            this.btnChuanHoa.UseVisualStyleBackColor = true;
            this.btnChuanHoa.Click += new System.EventHandler(this.btnChuanHoa_Click);
            // 
            // Form_XuLyChuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1077, 563);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChuanHoa);
            this.Controls.Add(this.btnMau);
            this.Controls.Add(this.btnDaoChuoi);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.rdChenCuoi);
            this.Controls.Add(this.rdChenDau);
            this.Controls.Add(this.txtChuoi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form_XuLyChuoi";
            this.Text = "Form_XuLyChuoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.RadioButton rdChenDau;
        private System.Windows.Forms.RadioButton rdChenCuoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnMau;
        private System.Windows.Forms.Button btnDaoChuoi;
        private System.Windows.Forms.Button btnChuanHoa;
    }
}