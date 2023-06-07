namespace HinhTron
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
            this.btnXemKQ = new System.Windows.Forms.Button();
            this.lbPerimeter = new System.Windows.Forms.Label();
            this.lbArea = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtOtherY = new System.Windows.Forms.TextBox();
            this.txtCenterY = new System.Windows.Forms.TextBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtOtherX = new System.Windows.Forms.TextBox();
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXemKQ
            // 
            this.btnXemKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemKQ.Location = new System.Drawing.Point(278, 211);
            this.btnXemKQ.Name = "btnXemKQ";
            this.btnXemKQ.Size = new System.Drawing.Size(200, 49);
            this.btnXemKQ.TabIndex = 21;
            this.btnXemKQ.Text = "Xem kết quả";
            this.btnXemKQ.UseVisualStyleBackColor = true;
            // 
            // lbPerimeter
            // 
            this.lbPerimeter.AutoSize = true;
            this.lbPerimeter.Location = new System.Drawing.Point(191, 401);
            this.lbPerimeter.Name = "lbPerimeter";
            this.lbPerimeter.Size = new System.Drawing.Size(46, 16);
            this.lbPerimeter.TabIndex = 15;
            this.lbPerimeter.Text = "Chu vi:";
            // 
            // lbArea
            // 
            this.lbArea.AutoSize = true;
            this.lbArea.Location = new System.Drawing.Point(191, 356);
            this.lbArea.Name = "lbArea";
            this.lbArea.Size = new System.Drawing.Size(61, 16);
            this.lbArea.TabIndex = 16;
            this.lbArea.Text = "Diện tích:";
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResult.Location = new System.Drawing.Point(148, 263);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(409, 62);
            this.lbResult.TabIndex = 17;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbResult.Click += new System.EventHandler(this.BtnXemKQ_Click);
            // 
            // txtOtherY
            // 
            this.txtOtherY.Location = new System.Drawing.Point(435, 168);
            this.txtOtherY.Name = "txtOtherY";
            this.txtOtherY.Size = new System.Drawing.Size(100, 22);
            this.txtOtherY.TabIndex = 20;
            // 
            // txtCenterY
            // 
            this.txtCenterY.Location = new System.Drawing.Point(435, 32);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(100, 22);
            this.txtCenterY.TabIndex = 14;
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(237, 96);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(119, 22);
            this.txtRadius.TabIndex = 18;
            // 
            // txtOtherX
            // 
            this.txtOtherX.Location = new System.Drawing.Point(258, 165);
            this.txtOtherX.Name = "txtOtherX";
            this.txtOtherX.Size = new System.Drawing.Size(100, 22);
            this.txtOtherX.TabIndex = 19;
            // 
            // txtCenterX
            // 
            this.txtCenterX.Location = new System.Drawing.Point(258, 35);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(100, 22);
            this.txtCenterX.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bán kính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Điểm khác:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "X:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "X:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tọa độ tâm:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXemKQ);
            this.Controls.Add(this.lbPerimeter);
            this.Controls.Add(this.lbArea);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtOtherY);
            this.Controls.Add(this.txtCenterY);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.txtOtherX);
            this.Controls.Add(this.txtCenterX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXemKQ;
        private System.Windows.Forms.Label lbPerimeter;
        private System.Windows.Forms.Label lbArea;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtOtherY;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtOtherX;
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

