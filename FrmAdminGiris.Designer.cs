namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            panelResimler = new Panel();
            panelOTP = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            btnOtpDogrula = new Button();
            label6 = new Label();
            txtTelefonOtp = new MaskedTextBox();
            txtEmailOtp = new MaskedTextBox();
            label5 = new Label();
            panelGiris = new Panel();
            btnSifremiUnuttum = new Button();
            mskSifre = new MaskedTextBox();
            pictureBox5 = new PictureBox();
            btnGeri = new Button();
            btnGiris = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            pictureBox6 = new PictureBox();
            panelIlkGiris = new Panel();
            mskYeniSifreTekrar = new MaskedTextBox();
            mskYeniSifre = new MaskedTextBox();
            btnKaydet = new Button();
            lblYeniSifreTekrar = new Label();
            lblYeniSifre = new Label();
            btnGERİ = new Button();
            lblTalimat = new Label();
            btnDevam = new Button();
            checkBox4 = new CheckBox();
            pb4 = new PictureBox();
            checkBox3 = new CheckBox();
            pb1 = new PictureBox();
            checkBox2 = new CheckBox();
            pb2 = new PictureBox();
            checkBox1 = new CheckBox();
            pb3 = new PictureBox();
            panelResimler.SuspendLayout();
            panelOTP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panelIlkGiris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb3).BeginInit();
            SuspendLayout();
            // 
            // panelResimler
            // 
            panelResimler.BackColor = SystemColors.ActiveCaption;
            panelResimler.Controls.Add(pictureBox6);
            panelResimler.Controls.Add(btnGERİ);
            panelResimler.Controls.Add(lblTalimat);
            panelResimler.Controls.Add(btnDevam);
            panelResimler.Controls.Add(checkBox4);
            panelResimler.Controls.Add(pb4);
            panelResimler.Controls.Add(checkBox3);
            panelResimler.Controls.Add(pb1);
            panelResimler.Controls.Add(checkBox2);
            panelResimler.Controls.Add(pb2);
            panelResimler.Controls.Add(checkBox1);
            panelResimler.Controls.Add(pb3);
            panelResimler.Location = new Point(0, 0);
            panelResimler.Name = "panelResimler";
            panelResimler.Size = new Size(886, 387);
            panelResimler.TabIndex = 27;
            // 
            // panelOTP
            // 
            panelOTP.BackColor = Color.FromArgb(255, 128, 0);
            panelOTP.Controls.Add(pictureBox1);
            panelOTP.Controls.Add(button1);
            panelOTP.Controls.Add(btnOtpDogrula);
            panelOTP.Controls.Add(label6);
            panelOTP.Controls.Add(txtTelefonOtp);
            panelOTP.Controls.Add(txtEmailOtp);
            panelOTP.Controls.Add(label5);
            panelOTP.Dock = DockStyle.Top;
            panelOTP.Location = new Point(0, 650);
            panelOTP.Name = "panelOTP";
            panelOTP.Size = new Size(886, 469);
            panelOTP.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(1, 154);
            button1.Name = "button1";
            button1.Size = new Size(46, 36);
            button1.TabIndex = 40;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnOtpDogrula
            // 
            btnOtpDogrula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnOtpDogrula.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            btnOtpDogrula.Location = new Point(629, 109);
            btnOtpDogrula.Name = "btnOtpDogrula";
            btnOtpDogrula.Size = new Size(232, 83);
            btnOtpDogrula.TabIndex = 32;
            btnOtpDogrula.Text = "Şifreleri Doğrula";
            btnOtpDogrula.UseVisualStyleBackColor = true;
            btnOtpDogrula.Click += btnOtpDogrula_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(63, 161);
            label6.Name = "label6";
            label6.Size = new Size(398, 32);
            label6.TabIndex = 36;
            label6.Text = "Telefonunuza gelen şifreyi girin :";
            // 
            // txtTelefonOtp
            // 
            txtTelefonOtp.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            txtTelefonOtp.Location = new Point(498, 154);
            txtTelefonOtp.Name = "txtTelefonOtp";
            txtTelefonOtp.Size = new Size(100, 39);
            txtTelefonOtp.TabIndex = 33;
            // 
            // txtEmailOtp
            // 
            txtEmailOtp.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            txtEmailOtp.Location = new Point(498, 109);
            txtEmailOtp.Name = "txtEmailOtp";
            txtEmailOtp.Size = new Size(100, 39);
            txtEmailOtp.TabIndex = 32;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(76, 112);
            label5.Name = "label5";
            label5.Size = new Size(385, 32);
            label5.TabIndex = 34;
            label5.Text = "E-posta'nıza gelen şifreyi girin :";
            // 
            // panelGiris
            // 
            panelGiris.BackColor = Color.FromArgb(192, 192, 0);
            panelGiris.Controls.Add(btnSifremiUnuttum);
            panelGiris.Controls.Add(mskSifre);
            panelGiris.Controls.Add(pictureBox5);
            panelGiris.Controls.Add(btnGeri);
            panelGiris.Controls.Add(btnGiris);
            panelGiris.Controls.Add(label3);
            panelGiris.Controls.Add(label2);
            panelGiris.Controls.Add(label1);
            panelGiris.Controls.Add(txtKullaniciAdi);
            panelGiris.Dock = DockStyle.Top;
            panelGiris.Location = new Point(0, 245);
            panelGiris.Name = "panelGiris";
            panelGiris.Size = new Size(886, 405);
            panelGiris.TabIndex = 25;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSifremiUnuttum.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            btnSifremiUnuttum.Location = new Point(142, 272);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(246, 83);
            btnSifremiUnuttum.TabIndex = 62;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = true;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // mskSifre
            // 
            mskSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            mskSifre.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            mskSifre.Location = new Point(344, 123);
            mskSifre.Name = "mskSifre";
            mskSifre.Size = new Size(341, 39);
            mskSifre.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(326, 197);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 49);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 61;
            pictureBox5.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGeri.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            btnGeri.Location = new Point(395, 197);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(199, 49);
            btnGeri.TabIndex = 2;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = true;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGiris.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            btnGiris.Location = new Point(395, 272);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(366, 83);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(67, 77);
            label3.Name = "label3";
            label3.Size = new Size(0, 32);
            label3.TabIndex = 58;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(247, 126);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 57;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(157, 63);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 56;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKullaniciAdi.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            txtKullaniciAdi.Location = new Point(344, 60);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(341, 39);
            txtKullaniciAdi.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 129);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 36);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 39;
            pictureBox6.TabStop = false;
            // 
            // panelIlkGiris
            // 
            panelIlkGiris.BackColor = Color.Cyan;
            panelIlkGiris.Controls.Add(mskYeniSifreTekrar);
            panelIlkGiris.Controls.Add(mskYeniSifre);
            panelIlkGiris.Controls.Add(btnKaydet);
            panelIlkGiris.Controls.Add(lblYeniSifreTekrar);
            panelIlkGiris.Controls.Add(lblYeniSifre);
            panelIlkGiris.Dock = DockStyle.Top;
            panelIlkGiris.Location = new Point(0, 0);
            panelIlkGiris.Name = "panelIlkGiris";
            panelIlkGiris.Size = new Size(886, 245);
            panelIlkGiris.TabIndex = 24;
            panelIlkGiris.Visible = false;
            // 
            // mskYeniSifreTekrar
            // 
            mskYeniSifreTekrar.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            mskYeniSifreTekrar.Location = new Point(513, 100);
            mskYeniSifreTekrar.Name = "mskYeniSifreTekrar";
            mskYeniSifreTekrar.Size = new Size(127, 39);
            mskYeniSifreTekrar.TabIndex = 28;
            // 
            // mskYeniSifre
            // 
            mskYeniSifre.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            mskYeniSifre.Location = new Point(513, 58);
            mskYeniSifre.Name = "mskYeniSifre";
            mskYeniSifre.Size = new Size(127, 39);
            mskYeniSifre.TabIndex = 27;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnKaydet.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            btnKaydet.Location = new Point(348, 156);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(247, 61);
            btnKaydet.TabIndex = 29;
            btnKaydet.Text = "Şifreyi Güncelle";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblYeniSifreTekrar
            // 
            lblYeniSifreTekrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblYeniSifreTekrar.AutoSize = true;
            lblYeniSifreTekrar.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            lblYeniSifreTekrar.Location = new Point(158, 104);
            lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            lblYeniSifreTekrar.Size = new Size(320, 32);
            lblYeniSifreTekrar.TabIndex = 31;
            lblYeniSifreTekrar.Text = "Yeni şifrenizi tekrar girin :";
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic);
            lblYeniSifre.Location = new Point(238, 65);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(240, 32);
            lblYeniSifre.TabIndex = 30;
            lblYeniSifre.Text = "Yeni şifrenizi girin :";
            // 
            // btnGERİ
            // 
            btnGERİ.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGERİ.Location = new Point(0, 168);
            btnGERİ.Name = "btnGERİ";
            btnGERİ.Size = new Size(67, 36);
            btnGERİ.TabIndex = 38;
            btnGERİ.Text = "Geri";
            btnGERİ.UseVisualStyleBackColor = true;
            btnGERİ.Click += btnGERİ_Click;
            // 
            // lblTalimat
            // 
            lblTalimat.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTalimat.AutoSize = true;
            lblTalimat.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            lblTalimat.Location = new Point(132, 61);
            lblTalimat.Name = "lblTalimat";
            lblTalimat.Size = new Size(83, 32);
            lblTalimat.TabIndex = 27;
            lblTalimat.Text = "label3";
            // 
            // btnDevam
            // 
            btnDevam.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnDevam.Location = new Point(318, 281);
            btnDevam.Name = "btnDevam";
            btnDevam.Size = new Size(186, 47);
            btnDevam.TabIndex = 32;
            btnDevam.Text = "Devam";
            btnDevam.UseVisualStyleBackColor = true;
            btnDevam.Click += btnDevam_Click;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(627, 222);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(15, 14);
            checkBox4.TabIndex = 36;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // pb4
            // 
            pb4.Location = new Point(586, 129);
            pb4.Name = "pb4";
            pb4.Size = new Size(83, 69);
            pb4.SizeMode = PictureBoxSizeMode.Zoom;
            pb4.TabIndex = 31;
            pb4.TabStop = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(463, 222);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 35;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // pb1
            // 
            pb1.Location = new Point(156, 129);
            pb1.Name = "pb1";
            pb1.Size = new Size(83, 69);
            pb1.SizeMode = PictureBoxSizeMode.Zoom;
            pb1.TabIndex = 28;
            pb1.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(325, 222);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 34;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // pb2
            // 
            pb2.Location = new Point(289, 129);
            pb2.Name = "pb2";
            pb2.Size = new Size(83, 69);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            pb2.TabIndex = 29;
            pb2.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(187, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 33;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // pb3
            // 
            pb3.Location = new Point(432, 129);
            pb3.Name = "pb3";
            pb3.Size = new Size(83, 69);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            pb3.TabIndex = 30;
            pb3.TabStop = false;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(886, 1061);
            Controls.Add(panelOTP);
            Controls.Add(panelResimler);
            Controls.Add(panelGiris);
            Controls.Add(panelIlkGiris);
            Name = "FrmAdminGiris";
            Text = "FrmAdminGiris";
            Load += FrmAdminGiris_Load;
            panelResimler.ResumeLayout(false);
            panelResimler.PerformLayout();
            panelOTP.ResumeLayout(false);
            panelOTP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelGiris.ResumeLayout(false);
            panelGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panelIlkGiris.ResumeLayout(false);
            panelIlkGiris.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox txtCaptcha;
        private TextBox txtOTP;
        private Button btnOTPGonder;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewRecaptcha;
        private Panel panelGiris;
        private MaskedTextBox mskSifre;
        private PictureBox pictureBox5;
        private Button btnGeri;
        private Button btnGiris;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private Panel panelResimler;
        private Panel panel3;
        private Label lblTalimat;
        private Button btnDevam;
        private CheckBox checkBox4;
        private PictureBox pb4;
        private CheckBox checkBox3;
        private PictureBox pb1;
        private CheckBox checkBox2;
        private PictureBox pb2;
        private CheckBox checkBox1;
        private PictureBox pb3;
        private Panel panelOTP;
        private MaskedTextBox txtTelefonOtp;
        private MaskedTextBox txtEmailOtp;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnOtpDogrula;
        private Label lblYeniSifre;
        private Label lblYeniSifreTekrar;
        private Button btnKaydet;
        private MaskedTextBox mskYeniSifre;
        private MaskedTextBox mskYeniSifreTekrar;
        private Panel panelIlkGiris;
        private Button btnSifremiUnuttum;
        private PictureBox pictureBox6;
        private Button btnGERİ;
        private PictureBox pictureBox1;
        private Button button1;
    }
}