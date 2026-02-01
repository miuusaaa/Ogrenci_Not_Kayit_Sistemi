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
            panelGiris = new Panel();
            btnSifremiUnuttum = new Button();
            pictureBox1 = new PictureBox();
            btnGeri = new Button();
            mskSifre = new MaskedTextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            panelResimler = new Panel();
            pictureBox6 = new PictureBox();
            btnGERİ = new Button();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btnDevam = new Button();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTalimat = new Label();
            panelOTP = new Panel();
            btnOtpDogrula = new Button();
            label6 = new Label();
            txtTelefonOtp = new MaskedTextBox();
            txtEmailOtp = new MaskedTextBox();
            label5 = new Label();
            panelIlkGiris = new Panel();
            mskYeniSifreTekrar = new MaskedTextBox();
            mskYeniSifre = new MaskedTextBox();
            btnKaydet = new Button();
            lblYeniSifreTekrar = new Label();
            lblYeniSifre = new Label();
            panelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelResimler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelOTP.SuspendLayout();
            panelIlkGiris.SuspendLayout();
            SuspendLayout();
            // 
            // panelGiris
            // 
            panelGiris.BackColor = SystemColors.ControlLightLight;
            panelGiris.Controls.Add(btnSifremiUnuttum);
            panelGiris.Controls.Add(pictureBox1);
            panelGiris.Controls.Add(btnGeri);
            panelGiris.Controls.Add(mskSifre);
            panelGiris.Controls.Add(txtKullaniciAdi);
            panelGiris.Controls.Add(label2);
            panelGiris.Controls.Add(label1);
            panelGiris.Controls.Add(btnGiris);
            panelGiris.Dock = DockStyle.Top;
            panelGiris.Location = new Point(0, 0);
            panelGiris.Name = "panelGiris";
            panelGiris.Size = new Size(800, 365);
            panelGiris.TabIndex = 26;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSifremiUnuttum.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnSifremiUnuttum.ForeColor = Color.DarkBlue;
            btnSifremiUnuttum.Location = new Point(481, 162);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(127, 96);
            btnSifremiUnuttum.TabIndex = 19;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = true;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(370, 281);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGeri.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnGeri.ForeColor = Color.DarkBlue;
            btnGeri.Location = new Point(429, 281);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(82, 51);
            btnGeri.TabIndex = 17;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // mskSifre
            // 
            mskSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mskSifre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            mskSifre.ForeColor = Color.DarkBlue;
            mskSifre.Location = new Point(454, 90);
            mskSifre.Name = "mskSifre";
            mskSifre.Size = new Size(179, 39);
            mskSifre.TabIndex = 16;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKullaniciAdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtKullaniciAdi.ForeColor = Color.DarkBlue;
            txtKullaniciAdi.Location = new Point(454, 33);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(179, 39);
            txtKullaniciAdi.TabIndex = 15;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(308, 97);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 14;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(224, 31);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 13;
            label1.Text = "Kullanıcı Adı :";
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGiris.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnGiris.ForeColor = Color.DarkBlue;
            btnGiris.Location = new Point(219, 162);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(245, 96);
            btnGiris.TabIndex = 12;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // panelResimler
            // 
            panelResimler.BackColor = SystemColors.ControlLightLight;
            panelResimler.Controls.Add(pictureBox6);
            panelResimler.Controls.Add(btnGERİ);
            panelResimler.Controls.Add(checkBox4);
            panelResimler.Controls.Add(checkBox3);
            panelResimler.Controls.Add(checkBox2);
            panelResimler.Controls.Add(checkBox1);
            panelResimler.Controls.Add(btnDevam);
            panelResimler.Controls.Add(pictureBox5);
            panelResimler.Controls.Add(pictureBox4);
            panelResimler.Controls.Add(pictureBox3);
            panelResimler.Controls.Add(pictureBox2);
            panelResimler.Controls.Add(lblTalimat);
            panelResimler.Dock = DockStyle.Top;
            panelResimler.Location = new Point(0, 728);
            panelResimler.Name = "panelResimler";
            panelResimler.Size = new Size(800, 324);
            panelResimler.TabIndex = 27;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(2, 127);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // btnGERİ
            // 
            btnGERİ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGERİ.ForeColor = Color.DarkBlue;
            btnGERİ.Location = new Point(2, 161);
            btnGERİ.Name = "btnGERİ";
            btnGERİ.Size = new Size(53, 36);
            btnGERİ.TabIndex = 36;
            btnGERİ.Text = "Geri";
            btnGERİ.UseVisualStyleBackColor = true;
            btnGERİ.Click += btnGERİ_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(618, 183);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(15, 14);
            checkBox4.TabIndex = 35;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(483, 183);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 34;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(348, 183);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 33;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(219, 183);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 32;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnDevam
            // 
            btnDevam.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnDevam.ForeColor = Color.DarkBlue;
            btnDevam.Location = new Point(362, 238);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(112, 62);
            btnDevam.TabIndex = 31;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = true;
            btnDevam.Click += btnDevam_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(572, 127);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 30;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(440, 127);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 29;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(308, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(176, 127);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // lblTalimat
            // 
            lblTalimat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTalimat.AutoSize = true;
            lblTalimat.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTalimat.ForeColor = Color.DarkBlue;
            lblTalimat.Location = new Point(204, 32);
            lblTalimat.Name = "lblTalimat";
            lblTalimat.Size = new Size(72, 30);
            lblTalimat.TabIndex = 26;
            lblTalimat.Text = "label3";
            // 
            // panelOTP
            // 
            panelOTP.BackColor = SystemColors.ControlLightLight;
            panelOTP.Controls.Add(btnOtpDogrula);
            panelOTP.Controls.Add(label6);
            panelOTP.Controls.Add(txtTelefonOtp);
            panelOTP.Controls.Add(txtEmailOtp);
            panelOTP.Controls.Add(label5);
            panelOTP.Dock = DockStyle.Top;
            panelOTP.Location = new Point(0, 542);
            panelOTP.Name = "panelOTP";
            panelOTP.Size = new Size(800, 186);
            panelOTP.TabIndex = 29;
            // 
            // btnOtpDogrula
            // 
            btnOtpDogrula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOtpDogrula.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnOtpDogrula.ForeColor = Color.DarkBlue;
            btnOtpDogrula.Location = new Point(572, 32);
            btnOtpDogrula.Name = "btnOtpDogrula";
            btnOtpDogrula.Size = new Size(176, 109);
            btnOtpDogrula.TabIndex = 32;
            btnOtpDogrula.Text = "Şifreleri Doğrula";
            btnOtpDogrula.UseVisualStyleBackColor = true;
            btnOtpDogrula.Click += btnOtpDogrula_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(31, 95);
            label6.Name = "label6";
            label6.Size = new Size(334, 30);
            label6.TabIndex = 36;
            label6.Text = "Telefonunuza gelen şifreyi girin :";
            // 
            // txtTelefonOtp
            // 
            txtTelefonOtp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTelefonOtp.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtTelefonOtp.Location = new Point(381, 92);
            txtTelefonOtp.Name = "txtTelefonOtp";
            txtTelefonOtp.Size = new Size(100, 39);
            txtTelefonOtp.TabIndex = 33;
            // 
            // txtEmailOtp
            // 
            txtEmailOtp.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmailOtp.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            txtEmailOtp.Location = new Point(381, 49);
            txtEmailOtp.Name = "txtEmailOtp";
            txtEmailOtp.Size = new Size(100, 39);
            txtEmailOtp.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(44, 49);
            label5.Name = "label5";
            label5.Size = new Size(321, 30);
            label5.TabIndex = 34;
            label5.Text = "E-posta'nıza gelen şifreyi girin :";
            // 
            // panelIlkGiris
            // 
            panelIlkGiris.BackColor = SystemColors.ControlLightLight;
            panelIlkGiris.Controls.Add(mskYeniSifreTekrar);
            panelIlkGiris.Controls.Add(mskYeniSifre);
            panelIlkGiris.Controls.Add(btnKaydet);
            panelIlkGiris.Controls.Add(lblYeniSifreTekrar);
            panelIlkGiris.Controls.Add(lblYeniSifre);
            panelIlkGiris.Dock = DockStyle.Top;
            panelIlkGiris.Location = new Point(0, 365);
            panelIlkGiris.Name = "panelIlkGiris";
            panelIlkGiris.Size = new Size(800, 177);
            panelIlkGiris.TabIndex = 28;
            panelIlkGiris.Visible = false;
            // 
            // mskYeniSifreTekrar
            // 
            mskYeniSifreTekrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mskYeniSifreTekrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            mskYeniSifreTekrar.Location = new Point(381, 102);
            mskYeniSifreTekrar.Name = "mskYeniSifreTekrar";
            mskYeniSifreTekrar.Size = new Size(100, 39);
            mskYeniSifreTekrar.TabIndex = 28;
            // 
            // mskYeniSifre
            // 
            mskYeniSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mskYeniSifre.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            mskYeniSifre.Location = new Point(381, 55);
            mskYeniSifre.Name = "mskYeniSifre";
            mskYeniSifre.Size = new Size(100, 39);
            mskYeniSifre.TabIndex = 27;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnKaydet.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnKaydet.ForeColor = Color.DarkBlue;
            btnKaydet.Location = new Point(572, 31);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(176, 112);
            btnKaydet.TabIndex = 29;
            btnKaydet.Text = "Şifreyi Güncelle";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblYeniSifreTekrar
            // 
            lblYeniSifreTekrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblYeniSifreTekrar.AutoSize = true;
            lblYeniSifreTekrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblYeniSifreTekrar.ForeColor = Color.DarkBlue;
            lblYeniSifreTekrar.Location = new Point(79, 107);
            lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            lblYeniSifreTekrar.Size = new Size(265, 30);
            lblYeniSifreTekrar.TabIndex = 31;
            lblYeniSifreTekrar.Text = "Yeni şifrenizi tekrar girin :";
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblYeniSifre.ForeColor = Color.DarkBlue;
            lblYeniSifre.Location = new Point(143, 55);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(201, 30);
            lblYeniSifre.TabIndex = 30;
            lblYeniSifre.Text = "Yeni şifrenizi girin :";
            // 
            // FrmOgretmenGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1061);
            Controls.Add(panelResimler);
            Controls.Add(panelOTP);
            Controls.Add(panelIlkGiris);
            Controls.Add(panelGiris);
            Name = "FrmOgretmenGiris";
            Text = "FrmOgretmenGiris";
            Load += FrmOgretmenGiris_Load;
            panelGiris.ResumeLayout(false);
            panelGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelResimler.ResumeLayout(false);
            panelResimler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelOTP.ResumeLayout(false);
            panelOTP.PerformLayout();
            panelIlkGiris.ResumeLayout(false);
            panelIlkGiris.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGiris;
        private PictureBox pictureBox1;
        private Button btnGeri;
        private MaskedTextBox mskSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private Button btnGiris;
        private Panel panelResimler;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btnDevam;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label lblTalimat;
        private Panel panelIlkGiris;
        private MaskedTextBox mskYeniSifreTekrar;
        private MaskedTextBox mskYeniSifre;
        private Button btnKaydet;
        private Label lblYeniSifreTekrar;
        private Label lblYeniSifre;
        private Panel panelOTP;
        private Button btnOtpDogrula;
        private Label label6;
        private MaskedTextBox txtTelefonOtp;
        private MaskedTextBox txtEmailOtp;
        private Label label5;
        private Button btnSifremiUnuttum;
        private PictureBox pictureBox6;
        private Button btnGERİ;
    }
}