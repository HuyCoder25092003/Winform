namespace SapXepMang
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btRandom = new System.Windows.Forms.Button();
            this.btSapXep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.txtArrayHigh = new System.Windows.Forms.TextBox();
            this.txtArrayDown = new System.Windows.Forms.TextBox();
            this.txtArrayDao = new System.Windows.Forms.TextBox();
            this.txtArrayChanLe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số phần tử";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(105, 14);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 26);
            this.txtNumber.TabIndex = 1;
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(410, 12);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(183, 28);
            this.btRandom.TabIndex = 2;
            this.btRandom.Text = "Tạo mảng ngẫu nhiên";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // btSapXep
            // 
            this.btSapXep.Location = new System.Drawing.Point(616, 12);
            this.btSapXep.Name = "btSapXep";
            this.btSapXep.Size = new System.Drawing.Size(183, 28);
            this.btSapXep.TabIndex = 2;
            this.btSapXep.Text = "Sắp xếp";
            this.btSapXep.UseVisualStyleBackColor = true;
            this.btSapXep.Click += new System.EventHandler(this.btSapXep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mảng ban đầu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mảng tăng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mảng giảm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mảng đảo";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mảng chẵn tăng, lẻ giảm";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(410, 82);
            this.txtArray.Name = "txtArray";
            this.txtArray.ReadOnly = true;
            this.txtArray.Size = new System.Drawing.Size(389, 26);
            this.txtArray.TabIndex = 4;
            // 
            // txtArrayHigh
            // 
            this.txtArrayHigh.Location = new System.Drawing.Point(410, 126);
            this.txtArrayHigh.Name = "txtArrayHigh";
            this.txtArrayHigh.ReadOnly = true;
            this.txtArrayHigh.Size = new System.Drawing.Size(389, 26);
            this.txtArrayHigh.TabIndex = 4;
            // 
            // txtArrayDown
            // 
            this.txtArrayDown.Location = new System.Drawing.Point(410, 173);
            this.txtArrayDown.Name = "txtArrayDown";
            this.txtArrayDown.ReadOnly = true;
            this.txtArrayDown.Size = new System.Drawing.Size(389, 26);
            this.txtArrayDown.TabIndex = 4;
            // 
            // txtArrayDao
            // 
            this.txtArrayDao.Location = new System.Drawing.Point(410, 219);
            this.txtArrayDao.Name = "txtArrayDao";
            this.txtArrayDao.ReadOnly = true;
            this.txtArrayDao.Size = new System.Drawing.Size(389, 26);
            this.txtArrayDao.TabIndex = 4;
            // 
            // txtArrayChanLe
            // 
            this.txtArrayChanLe.Location = new System.Drawing.Point(410, 255);
            this.txtArrayChanLe.Name = "txtArrayChanLe";
            this.txtArrayChanLe.ReadOnly = true;
            this.txtArrayChanLe.Size = new System.Drawing.Size(389, 26);
            this.txtArrayChanLe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 332);
            this.Controls.Add(this.txtArrayChanLe);
            this.Controls.Add(this.txtArrayDao);
            this.Controls.Add(this.txtArrayDown);
            this.Controls.Add(this.txtArrayHigh);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSapXep);
            this.Controls.Add(this.btRandom);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sắp xếp mảng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.Button btSapXep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.TextBox txtArrayHigh;
        private System.Windows.Forms.TextBox txtArrayDown;
        private System.Windows.Forms.TextBox txtArrayDao;
        private System.Windows.Forms.TextBox txtArrayChanLe;
    }
}

