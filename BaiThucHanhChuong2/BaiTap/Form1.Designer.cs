namespace BaiTap
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
            this.lbA = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btDT = new System.Windows.Forms.Button();
            this.btCV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(169, 70);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(52, 16);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "Canh a:";
            this.lbA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(170, 239);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(51, 16);
            this.lbC.TabIndex = 1;
            this.lbC.Text = "Canh c:";
            this.lbC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(169, 158);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(52, 16);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "Canh b:";
            this.lbB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbKQ
            // 
            this.lbKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbKQ.Location = new System.Drawing.Point(266, 291);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(324, 59);
            this.lbKQ.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(285, 57);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(305, 42);
            this.txtA.TabIndex = 5;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(285, 213);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(305, 42);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(285, 144);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(305, 42);
            this.txtB.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ket qua:";
            // 
            // btDT
            // 
            this.btDT.Location = new System.Drawing.Point(172, 389);
            this.btDT.Name = "btDT";
            this.btDT.Size = new System.Drawing.Size(111, 49);
            this.btDT.TabIndex = 10;
            this.btDT.Text = "Tinh DIen Tich";
            this.btDT.UseVisualStyleBackColor = true;
            this.btDT.Click += new System.EventHandler(this.btDT_Click);
            // 
            // btCV
            // 
            this.btCV.Location = new System.Drawing.Point(504, 389);
            this.btCV.Name = "btCV";
            this.btCV.Size = new System.Drawing.Size(111, 49);
            this.btCV.TabIndex = 11;
            this.btCV.Text = "Tinh CHu Vi";
            this.btCV.UseVisualStyleBackColor = true;
            this.btCV.Click += new System.EventHandler(this.btCV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCV);
            this.Controls.Add(this.btDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDT;
        private System.Windows.Forms.Button btCV;
    }
}

