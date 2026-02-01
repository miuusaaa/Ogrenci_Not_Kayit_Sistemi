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
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGiris.BackColor = Color.MediumSpringGreen;
            btnGiris.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            btnGiris.ForeColor = Color.CornflowerBlue;
            btnGiris.Location = new Point(310, 214);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(583, 96);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(88, 37);
            label1.Name = "label1";
            label1.Size = new Size(356, 65);
            label1.TabIndex = 1;
            label1.Text = "Tc Kimlik No :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(29, 114);
            label2.Name = "label2";
            label2.Size = new Size(415, 65);
            label2.TabIndex = 2;
            label2.Text = "Okul Numarası :";
            // 
            // txtTC
            // 
            txtTC.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTC.BackColor = Color.Aqua;
            txtTC.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            txtTC.ForeColor = SystemColors.ControlDarkDark;
            txtTC.Location = new Point(475, 31);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(603, 71);
            txtTC.TabIndex = 3;
            txtTC.KeyPress += txtTC_KeyPress;
            // 
            // txtOkulNo
            // 
            txtOkulNo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtOkulNo.BackColor = Color.Aqua;
            txtOkulNo.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic);
            txtOkulNo.ForeColor = SystemColors.ControlDarkDark;
            txtOkulNo.Location = new Point(475, 108);
            txtOkulNo.Name = "txtOkulNo";
            txtOkulNo.Size = new Size(603, 71);
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
            panel1.Location = new Point(109, 488);
            panel1.Name = "panel1";
            panel1.Size = new Size(937, 241);
            panel1.TabIndex = 5;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(817, 213);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(14, 13);
            radioButton4.TabIndex = 7;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(576, 213);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(14, 13);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(335, 213);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(14, 13);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(94, 213);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(14, 13);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(736, 32);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(168, 159);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(498, 32);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(168, 159);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(260, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(22, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 159);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblResimSec
            // 
            lblResimSec.AutoSize = true;
            lblResimSec.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblResimSec.ForeColor = SystemColors.Desktop;
            lblResimSec.Location = new Point(332, 429);
            lblResimSec.Name = "lblResimSec";
            lblResimSec.Size = new Size(478, 30);
            lblResimSec.TabIndex = 6;
            lblResimSec.Text = "Lütfen aşağıdaki resimlerden doğru olanı seçin.\r\n";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(332, 330);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(53, 57);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGeri.BackColor = Color.FromArgb(0, 0, 192);
            btnGeri.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGeri.ForeColor = Color.Crimson;
            btnGeri.Location = new Point(396, 330);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(453, 57);
            btnGeri.TabIndex = 12;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnDevam
            // 
            btnDevam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnDevam.BackColor = Color.Red;
            btnDevam.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDevam.ForeColor = Color.Cornsilk;
            btnDevam.Location = new Point(465, 745);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(255, 52);
            btnDevam.TabIndex = 14;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = false;
            btnDevam.Click += btnDevam_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(246, 233);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 57);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(405, 740);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(53, 57);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // FrmOgrenciGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(1100, 809);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
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
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
    }
}