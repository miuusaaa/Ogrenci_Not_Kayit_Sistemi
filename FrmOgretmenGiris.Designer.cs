namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgretmenGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenGiris));
            mskSifre = new MaskedTextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            btnGeri = new Button();
            pictureBox1 = new PictureBox();
            lblTalimat = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btnDevam = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // mskSifre
            // 
            mskSifre.Location = new Point(495, 165);
            mskSifre.Name = "mskSifre";
            mskSifre.Size = new Size(100, 23);
            mskSifre.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(495, 97);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(290, 154);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 7;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(206, 88);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı :";
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(334, 267);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(193, 96);
            btnGiris.TabIndex = 5;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnGeri
            // 
            btnGeri.Location = new Point(420, 384);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(82, 36);
            btnGeri.TabIndex = 10;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(361, 384);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // lblTalimat
            // 
            lblTalimat.AutoSize = true;
            lblTalimat.Location = new Point(411, 464);
            lblTalimat.Name = "lblTalimat";
            lblTalimat.Size = new Size(38, 15);
            lblTalimat.TabIndex = 12;
            lblTalimat.Text = "label3";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(189, 506);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(334, 506);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(451, 506);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(76, 45);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(585, 506);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // btnDevam
            // 
            btnDevam.Location = new Point(385, 601);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(75, 23);
            btnDevam.TabIndex = 21;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = true;
            btnDevam.Click += btnDevam_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(226, 562);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 22;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(373, 562);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 23;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(479, 562);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 24;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(621, 562);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(15, 14);
            checkBox4.TabIndex = 25;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // FrmOgretmenGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 636);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(btnDevam);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(lblTalimat);
            Controls.Add(pictureBox1);
            Controls.Add(btnGeri);
            Controls.Add(mskSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Name = "FrmOgretmenGiris";
            Text = "FrmOgretmenGiris";
            Load += FrmOgretmenGiris_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button btnGiris;
        private Button btnGeri;
        private PictureBox pictureBox1;
        private Label lblTalimat;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnDevam;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}