namespace CommonDialog
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
            this.btnOneFile = new System.Windows.Forms.Button();
            this.btnMultiFile = new System.Windows.Forms.Button();
            this.btnBrowserFolder = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.timerFadeOut = new System.Windows.Forms.Timer(this.components);
            this.timerFadeIn = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnOneFile
            // 
            this.btnOneFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneFile.Location = new System.Drawing.Point(12, 12);
            this.btnOneFile.Name = "btnOneFile";
            this.btnOneFile.Size = new System.Drawing.Size(386, 54);
            this.btnOneFile.TabIndex = 5;
            this.btnOneFile.Text = "Chọn một tập tin";
            this.btnOneFile.UseVisualStyleBackColor = true;
            this.btnOneFile.Click += new System.EventHandler(this.BtnOneFile_Click);
            // 
            // btnMultiFile
            // 
            this.btnMultiFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiFile.Location = new System.Drawing.Point(12, 105);
            this.btnMultiFile.Name = "btnMultiFile";
            this.btnMultiFile.Size = new System.Drawing.Size(386, 54);
            this.btnMultiFile.TabIndex = 6;
            this.btnMultiFile.Text = "Chọn nhiều tập tin";
            this.btnMultiFile.UseVisualStyleBackColor = true;
            this.btnMultiFile.Click += new System.EventHandler(this.BtnMultiFile_Click);
            // 
            // btnBrowserFolder
            // 
            this.btnBrowserFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowserFolder.Location = new System.Drawing.Point(12, 198);
            this.btnBrowserFolder.Name = "btnBrowserFolder";
            this.btnBrowserFolder.Size = new System.Drawing.Size(386, 54);
            this.btnBrowserFolder.TabIndex = 7;
            this.btnBrowserFolder.Text = "Chọn thư mục";
            this.btnBrowserFolder.UseVisualStyleBackColor = true;
            this.btnBrowserFolder.Click += new System.EventHandler(this.BtnBrowserFolder_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.Location = new System.Drawing.Point(12, 291);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(386, 54);
            this.btnBackColor.TabIndex = 8;
            this.btnBackColor.Text = "Chọn màu nền";
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.BtnBackColor_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForeColor.Location = new System.Drawing.Point(12, 384);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(386, 54);
            this.btnForeColor.TabIndex = 9;
            this.btnForeColor.Text = "Chọn màu chữ";
            this.btnForeColor.UseVisualStyleBackColor = true;
            this.btnForeColor.Click += new System.EventHandler(this.BtnForeColor_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Blue;
            this.textBox1.Location = new System.Drawing.Point(404, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(550, 460);
            this.textBox1.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(684, 501);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 54);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(404, 501);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(270, 54);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnFont
            // 
            this.btnFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.Location = new System.Drawing.Point(12, 500);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(386, 54);
            this.btnFont.TabIndex = 11;
            this.btnFont.Text = "Chọn font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.BtnFont_Click);
            // 
            // timerFadeOut
            // 
            this.timerFadeOut.Tick += new System.EventHandler(this.TimerFadeOut_Tick);
            // 
            // timerFadeIn
            // 
            this.timerFadeIn.Tick += new System.EventHandler(this.TimerFadeIn_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 616);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOneFile);
            this.Controls.Add(this.btnMultiFile);
            this.Controls.Add(this.btnBrowserFolder);
            this.Controls.Add(this.btnBackColor);
            this.Controls.Add(this.btnForeColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOneFile;
        private System.Windows.Forms.Button btnMultiFile;
        private System.Windows.Forms.Button btnBrowserFolder;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Timer timerFadeOut;
        private System.Windows.Forms.Timer timerFadeIn;
    }
}

