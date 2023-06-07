namespace Array
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
            this.lbArrInitial = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateArr = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colArrInitial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSumEven = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSumOdd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbArrInitial
            // 
            this.lbArrInitial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbArrInitial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbArrInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArrInitial.Location = new System.Drawing.Point(281, 78);
            this.lbArrInitial.Name = "lbArrInitial";
            this.lbArrInitial.Size = new System.Drawing.Size(398, 60);
            this.lbArrInitial.TabIndex = 10;
            this.lbArrInitial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStatistics
            // 
            this.btnStatistics.Location = new System.Drawing.Point(488, 160);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(191, 65);
            this.btnStatistics.TabIndex = 8;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(525, 15);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 22);
            this.txtAmount.TabIndex = 6;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Số phần tử:";
            // 
            // btnCreateArr
            // 
            this.btnCreateArr.Location = new System.Drawing.Point(281, 160);
            this.btnCreateArr.Name = "btnCreateArr";
            this.btnCreateArr.Size = new System.Drawing.Size(191, 65);
            this.btnCreateArr.TabIndex = 7;
            this.btnCreateArr.Text = "Tạo mảng";
            this.btnCreateArr.UseVisualStyleBackColor = true;
            this.btnCreateArr.Click += new System.EventHandler(this.BtnCreateArr_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colArrInitial,
            this.colSumEven,
            this.colSumOdd,
            this.colAvg,
            this.colPrime});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 235);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1070, 200);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // colArrInitial
            // 
            this.colArrInitial.Text = "Mảng ban đầu";
            this.colArrInitial.Width = 330;
            // 
            // colSumEven
            // 
            this.colSumEven.Text = "Tổng các số chẵn";
            this.colSumEven.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSumEven.Width = 230;
            // 
            // colSumOdd
            // 
            this.colSumOdd.Text = "Tổng các số lẻ";
            this.colSumOdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colSumOdd.Width = 200;
            // 
            // colAvg
            // 
            this.colAvg.Text = "Trung bình cộng";
            this.colAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colAvg.Width = 220;
            // 
            // colPrime
            // 
            this.colPrime.Text = "Các số nguyên tố";
            this.colPrime.Width = 330;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 493);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbArrInitial);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateArr);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbArrInitial;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateArr;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colArrInitial;
        private System.Windows.Forms.ColumnHeader colSumEven;
        private System.Windows.Forms.ColumnHeader colSumOdd;
        private System.Windows.Forms.ColumnHeader colAvg;
        private System.Windows.Forms.ColumnHeader colPrime;
    }
}

