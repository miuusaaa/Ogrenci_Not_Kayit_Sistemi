namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            txtTC = new TextBox();
            txtOkulNo = new TextBox();
            panel1 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            lblResimSec = new Label();
            pictureBox5 = new PictureBox();
            btnGeri = new Button();
            btnDevam = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(331, 216);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(193, 96);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(231, 58);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 1;
            label1.Text = "Tc Kimlik No :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(205, 124);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 2;
            label2.Text = "Okul Numarası :";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(520, 67);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 3;
            txtTC.KeyPress += txtTC_KeyPress;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Location = new Point(520, 135);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(100, 23);
            txtOkulNo.TabIndex = 4;
            txtOkulNo.KeyPress += txtOkulNo_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(145, 450);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 115);
            panel1.TabIndex = 5;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(532, 88);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(365, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(222, 88);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(75, 88);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(490, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(326, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(177, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblResimSec
            // 
            lblResimSec.AutoSize = true;
            lblResimSec.Location = new Point(294, 398);
            lblResimSec.Name = "lblResimSec";
            lblResimSec.Size = new Size(255, 15);
            lblResimSec.TabIndex = 6;
            lblResimSec.Text = "Lütfen aşağıdaki resimlerden doğru olanı seçin.\r\n";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(357, 328);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(416, 328);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(82, 36);
            btnGeri.TabIndex = 12;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnDevam
            // 
            btnDevam.Location = new Point(407, 588);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(75, 23);
            btnDevam.TabIndex = 14;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = true;
            btnDevam.Click += btnDevam_Click;
            // 
            // FrmOgrenciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 635);
            Controls.Add(btnDevam);
            Controls.Add(pictureBox5);
            Controls.Add(btnGeri);
            Controls.Add(lblResimSec);
            Controls.Add(panel1);
            Controls.Add(txtOkulNo);
            Controls.Add(txtTC);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Name = "FrmOgrenciGiris";
            Text = "FrmOgrenciGiris";
            Load += FrmOgrenciGiris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Label label1;
        private Label label2;
        private TextBox txtTC;
        private TextBox txtOkulNo;
        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label lblResimSec;
        private PictureBox pictureBox5;
        private Button btnGeri;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button btnDevam;
    }
}