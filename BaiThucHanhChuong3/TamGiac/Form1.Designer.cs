namespace TamGiac
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCanh1 = new System.Windows.Forms.TextBox();
            this.txtCanh2 = new System.Windows.Forms.TextBox();
            this.txtCanh3 = new System.Windows.Forms.TextBox();
            this.btDienTich = new System.Windows.Forms.Button();
            this.btChuVi = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cạnh 1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cạnh 2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cạnh 3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCanh1
            // 
            this.txtCanh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanh1.Location = new System.Drawing.Point(108, 46);
            this.txtCanh1.Name = "txtCanh1";
            this.txtCanh1.Size = new System.Drawing.Size(472, 30);
            this.txtCanh1.TabIndex = 1;
            this.txtCanh1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCanh2
            // 
            this.txtCanh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanh2.Location = new System.Drawing.Point(108, 96);
            this.txtCanh2.Name = "txtCanh2";
            this.txtCanh2.Size = new System.Drawing.Size(472, 30);
            this.txtCanh2.TabIndex = 2;
            this.txtCanh2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCanh3
            // 
            this.txtCanh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCanh3.Location = new System.Drawing.Point(108, 146);
            this.txtCanh3.Name = "txtCanh3";
            this.txtCanh3.Size = new System.Drawing.Size(472, 30);
            this.txtCanh3.TabIndex = 3;
            this.txtCanh3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDienTich
            // 
            this.btDienTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDienTich.Location = new System.Drawing.Point(110, 352);
            this.btDienTich.Name = "btDienTich";
            this.btDienTich.Size = new System.Drawing.Size(145, 34);
            this.btDienTich.TabIndex = 4;
            this.btDienTich.Text = "Diện tích";
            this.btDienTich.UseVisualStyleBackColor = true;
            this.btDienTich.Click += new System.EventHandler(this.btDienTich_Click);
            // 
            // btChuVi
            // 
            this.btChuVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuVi.Location = new System.Drawing.Point(499, 352);
            this.btChuVi.Name = "btChuVi";
            this.btChuVi.Size = new System.Drawing.Size(145, 34);
            this.btChuVi.TabIndex = 5;
            this.btChuVi.Text = "Chu Vi";
            this.btChuVi.UseVisualStyleBackColor = true;
            this.btChuVi.Click += new System.EventHandler(this.btChuVi_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(149, 271);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(456, 45);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 463);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btChuVi);
            this.Controls.Add(this.btDienTich);
            this.Controls.Add(this.txtCanh3);
            this.Controls.Add(this.txtCanh2);
            this.Controls.Add(this.txtCanh1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCanh1;
        private System.Windows.Forms.TextBox txtCanh2;
        private System.Windows.Forms.TextBox txtCanh3;
        private System.Windows.Forms.Button btDienTich;
        private System.Windows.Forms.Button btChuVi;
        private System.Windows.Forms.TextBox txtResult;
    }
}

