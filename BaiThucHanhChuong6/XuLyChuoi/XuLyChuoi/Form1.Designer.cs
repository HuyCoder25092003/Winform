namespace XuLyChuoi
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
            this.lbTieuDe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtString3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChen = new System.Windows.Forms.TextBox();
            this.btChen = new System.Windows.Forms.Button();
            this.btThayThe = new System.Windows.Forms.Button();
            this.btDao = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btChuanHoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartPos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btLayChuoiCon = new System.Windows.Forms.Button();
            this.btKhoiPhuc = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTieuDe
            // 
            this.lbTieuDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lbTieuDe.Name = "lbTieuDe";
            this.lbTieuDe.Size = new System.Drawing.Size(666, 48);
            this.lbTieuDe.TabIndex = 0;
            this.lbTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chuỗi s1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chuỗi s2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtString1
            // 
            this.txtString1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtString1.Location = new System.Drawing.Point(102, 93);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(560, 26);
            this.txtString1.TabIndex = 2;
            this.txtString1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(102, 129);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(203, 26);
            this.txtString2.TabIndex = 3;
            this.txtString2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Chuỗi s3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtString3
            // 
            this.txtString3.Location = new System.Drawing.Point(388, 130);
            this.txtString3.Name = "txtString3";
            this.txtString3.Size = new System.Drawing.Size(274, 26);
            this.txtString3.TabIndex = 3;
            this.txtString3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btChen);
            this.groupBox1.Controls.Add(this.txtChen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(27, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chèn chuỗi s2 vào s1";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Vị trí";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtChen
            // 
            this.txtChen.Location = new System.Drawing.Point(55, 39);
            this.txtChen.Name = "txtChen";
            this.txtChen.Size = new System.Drawing.Size(46, 26);
            this.txtChen.TabIndex = 1;
            this.txtChen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btChen
            // 
            this.btChen.Location = new System.Drawing.Point(107, 36);
            this.btChen.Name = "btChen";
            this.btChen.Size = new System.Drawing.Size(75, 33);
            this.btChen.TabIndex = 2;
            this.btChen.Text = "Chèn";
            this.btChen.UseVisualStyleBackColor = true;
            this.btChen.Click += new System.EventHandler(this.btChen_Click);
            // 
            // btThayThe
            // 
            this.btThayThe.Location = new System.Drawing.Point(284, 191);
            this.btThayThe.Name = "btThayThe";
            this.btThayThe.Size = new System.Drawing.Size(164, 38);
            this.btThayThe.TabIndex = 6;
            this.btThayThe.Text = "Thay thế s2 bằng s3";
            this.btThayThe.UseVisualStyleBackColor = true;
            this.btThayThe.Click += new System.EventHandler(this.btThayThe_Click);
            // 
            // btDao
            // 
            this.btDao.Location = new System.Drawing.Point(487, 191);
            this.btDao.Name = "btDao";
            this.btDao.Size = new System.Drawing.Size(175, 38);
            this.btDao.TabIndex = 6;
            this.btDao.Text = "Đảo từ trong s1";
            this.btDao.UseVisualStyleBackColor = true;
            this.btDao.Click += new System.EventHandler(this.btDao_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(284, 235);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(164, 38);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa s2 trong s1";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btChuanHoa
            // 
            this.btChuanHoa.Location = new System.Drawing.Point(487, 235);
            this.btChuanHoa.Name = "btChuanHoa";
            this.btChuanHoa.Size = new System.Drawing.Size(175, 38);
            this.btChuanHoa.TabIndex = 6;
            this.btChuanHoa.Text = "Chuản hóa chuỗi";
            this.btChuanHoa.UseVisualStyleBackColor = true;
            this.btChuanHoa.Click += new System.EventHandler(this.btChuanHoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btLayChuoiCon);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNumber);
            this.groupBox2.Controls.Add(this.txtStartPos);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(27, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lấy chuỗi con trong s1";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Từ vị trí";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStartPos
            // 
            this.txtStartPos.Location = new System.Drawing.Point(69, 32);
            this.txtStartPos.Name = "txtStartPos";
            this.txtStartPos.Size = new System.Drawing.Size(28, 26);
            this.txtStartPos.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(103, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số ký tự";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(184, 32);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(28, 26);
            this.txtNumber.TabIndex = 1;
            // 
            // btLayChuoiCon
            // 
            this.btLayChuoiCon.Location = new System.Drawing.Point(228, 32);
            this.btLayChuoiCon.Name = "btLayChuoiCon";
            this.btLayChuoiCon.Size = new System.Drawing.Size(115, 26);
            this.btLayChuoiCon.TabIndex = 3;
            this.btLayChuoiCon.Text = "Lấy chuỗi con";
            this.btLayChuoiCon.UseVisualStyleBackColor = true;
            this.btLayChuoiCon.Click += new System.EventHandler(this.btLayChuoiCon_Click);
            // 
            // btKhoiPhuc
            // 
            this.btKhoiPhuc.Location = new System.Drawing.Point(412, 309);
            this.btKhoiPhuc.Name = "btKhoiPhuc";
            this.btKhoiPhuc.Size = new System.Drawing.Size(117, 43);
            this.btKhoiPhuc.TabIndex = 8;
            this.btKhoiPhuc.Text = "Khôi phục";
            this.btKhoiPhuc.UseVisualStyleBackColor = true;
            this.btKhoiPhuc.Click += new System.EventHandler(this.btKhoiPhuc_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 394);
            this.Controls.Add(this.btKhoiPhuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btChuanHoa);
            this.Controls.Add(this.btDao);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThayThe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtString3);
            this.Controls.Add(this.txtString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTieuDe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử lý chuỗi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTieuDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtString3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btChen;
        private System.Windows.Forms.TextBox txtChen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btThayThe;
        private System.Windows.Forms.Button btDao;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btChuanHoa;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStartPos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btLayChuoiCon;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btKhoiPhuc;
        private System.Windows.Forms.Timer timer1;
    }
}

