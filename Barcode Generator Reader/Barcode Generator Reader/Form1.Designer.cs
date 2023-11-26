namespace Barcode_Generator_Reader
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.barcode_btn = new System.Windows.Forms.Button();
            this.qr_btn = new System.Windows.Forms.Button();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.okut_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(12, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 274);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Barrcode";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "QRCode";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 2;
            // 
            // barcode_btn
            // 
            this.barcode_btn.Location = new System.Drawing.Point(345, 14);
            this.barcode_btn.Name = "barcode_btn";
            this.barcode_btn.Size = new System.Drawing.Size(75, 23);
            this.barcode_btn.TabIndex = 3;
            this.barcode_btn.Text = "Barcode";
            this.barcode_btn.UseVisualStyleBackColor = true;
            this.barcode_btn.Click += new System.EventHandler(this.barcode_btn_Click);
            // 
            // qr_btn
            // 
            this.qr_btn.Location = new System.Drawing.Point(345, 49);
            this.qr_btn.Name = "qr_btn";
            this.qr_btn.Size = new System.Drawing.Size(75, 23);
            this.qr_btn.TabIndex = 3;
            this.qr_btn.Text = "QRCode";
            this.qr_btn.UseVisualStyleBackColor = true;
            this.qr_btn.Click += new System.EventHandler(this.qr_btn_Click);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(546, 124);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(94, 34);
            this.kaydet_btn.TabIndex = 4;
            this.kaydet_btn.Text = "Kaydet";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // okut_btn
            // 
            this.okut_btn.Location = new System.Drawing.Point(378, 124);
            this.okut_btn.Name = "okut_btn";
            this.okut_btn.Size = new System.Drawing.Size(75, 23);
            this.okut_btn.TabIndex = 5;
            this.okut_btn.Text = "Qr/bc Oku";
            this.okut_btn.UseVisualStyleBackColor = true;
            this.okut_btn.Click += new System.EventHandler(this.okut_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.okut_btn);
            this.Controls.Add(this.kaydet_btn);
            this.Controls.Add(this.qr_btn);
            this.Controls.Add(this.barcode_btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button barcode_btn;
        private System.Windows.Forms.Button qr_btn;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button okut_btn;
    }
}

