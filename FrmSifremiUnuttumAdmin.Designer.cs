namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmSifremiUnuttumAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttumAdmin));
            panelKodGonder = new Panel();
            pictureBox1 = new PictureBox();
            btnGeri = new Button();
            btnKodGonder = new Button();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelKoduDogrula = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            btnKoduDogrula = new Button();
            txtKod = new TextBox();
            label3 = new Label();
            lblOtpBilgi = new Label();
            panelSifreGuncelle = new Panel();
            button1 = new Button();
            btnSifreyiGuncelle = new Button();
            txtYeniSifreTekrar = new TextBox();
            txtYeniSifre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            panelKodGonder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelKoduDogrula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelSifreGuncelle.SuspendLayout();
            SuspendLayout();
            // 
            // panelKodGonder
            // 
            panelKodGonder.BackColor = Color.FromArgb(0, 192, 0);
            panelKodGonder.Controls.Add(pictureBox1);
            panelKodGonder.Controls.Add(btnGeri);
            panelKodGonder.Controls.Add(btnKodGonder);
            panelKodGonder.Controls.Add(txtKullaniciAdi);
            panelKodGonder.Controls.Add(label2);
            panelKodGonder.Controls.Add(label1);
            panelKodGonder.Dock = DockStyle.Top;
            panelKodGonder.Location = new Point(0, 0);
            panelKodGonder.Name = "panelKodGonder";
            panelKodGonder.Size = new Size(860, 230);
            panelKodGonder.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(402, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGeri.BackColor = Color.FromArgb(255, 128, 0);
            btnGeri.Location = new Point(461, 166);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(84, 36);
            btnGeri.TabIndex = 25;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKodGonder
            // 
            btnKodGonder.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnKodGonder.BackColor = Color.FromArgb(255, 128, 0);
            btnKodGonder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKodGonder.Location = new Point(644, 76);
            btnKodGonder.Name = "btnKodGonder";
            btnKodGonder.Size = new Size(139, 79);
            btnKodGonder.TabIndex = 24;
            btnKodGonder.Text = "Kod Gönder";
            btnKodGonder.UseVisualStyleBackColor = false;
            btnKodGonder.Click += btnKodGonder_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKullaniciAdi.BackColor = Color.FromArgb(255, 128, 0);
            txtKullaniciAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(332, 95);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(242, 35);
            txtKullaniciAdi.TabIndex = 23;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(143, 100);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 22;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(829, 25);
            label1.TabIndex = 21;
            label1.Text = "Lütfen kullanıcı adınızı girin . Eğer eşleşme varsa e-posta ve telefonunuza kod göndereceğiz.";
            // 
            // panelKoduDogrula
            // 
            panelKoduDogrula.BackColor = Color.FromArgb(0, 192, 0);
            panelKoduDogrula.Controls.Add(pictureBox2);
            panelKoduDogrula.Controls.Add(button2);
            panelKoduDogrula.Controls.Add(btnKoduDogrula);
            panelKoduDogrula.Controls.Add(txtKod);
            panelKoduDogrula.Controls.Add(label3);
            panelKoduDogrula.Controls.Add(lblOtpBilgi);
            panelKoduDogrula.Dock = DockStyle.Top;
            panelKoduDogrula.Location = new Point(0, 230);
            panelKoduDogrula.Name = "panelKoduDogrula";
            panelKoduDogrula.Size = new Size(860, 230);
            panelKoduDogrula.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.RoyalBlue;
            button2.Location = new Point(0, 121);
            button2.Name = "button2";
            button2.Size = new Size(53, 36);
            button2.TabIndex = 27;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnKoduDogrula
            // 
            btnKoduDogrula.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnKoduDogrula.BackColor = Color.FromArgb(255, 128, 0);
            btnKoduDogrula.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKoduDogrula.Location = new Point(534, 121);
            btnKoduDogrula.Name = "btnKoduDogrula";
            btnKoduDogrula.Size = new Size(249, 74);
            btnKoduDogrula.TabIndex = 26;
            btnKoduDogrula.Text = "Kodu Doğrula";
            btnKoduDogrula.UseVisualStyleBackColor = false;
            btnKoduDogrula.Click += btnKoduDogrula_Click;
            // 
            // txtKod
            // 
            txtKod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtKod.BackColor = Color.FromArgb(255, 128, 0);
            txtKod.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKod.Location = new Point(327, 121);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(160, 71);
            txtKod.TabIndex = 25;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(95, 107);
            label3.Name = "label3";
            label3.Size = new Size(192, 86);
            label3.TabIndex = 24;
            label3.Text = "Kod :";
            // 
            // lblOtpBilgi
            // 
            lblOtpBilgi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblOtpBilgi.AutoSize = true;
            lblOtpBilgi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOtpBilgi.Location = new Point(133, 31);
            lblOtpBilgi.Name = "lblOtpBilgi";
            lblOtpBilgi.Size = new Size(0, 25);
            lblOtpBilgi.TabIndex = 23;
            // 
            // panelSifreGuncelle
            // 
            panelSifreGuncelle.BackColor = Color.FromArgb(0, 192, 0);
            panelSifreGuncelle.Controls.Add(button1);
            panelSifreGuncelle.Controls.Add(btnSifreyiGuncelle);
            panelSifreGuncelle.Controls.Add(txtYeniSifreTekrar);
            panelSifreGuncelle.Controls.Add(txtYeniSifre);
            panelSifreGuncelle.Controls.Add(label6);
            panelSifreGuncelle.Controls.Add(label5);
            panelSifreGuncelle.Dock = DockStyle.Top;
            panelSifreGuncelle.Location = new Point(0, 460);
            panelSifreGuncelle.Name = "panelSifreGuncelle";
            panelSifreGuncelle.Size = new Size(860, 230);
            panelSifreGuncelle.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(409, 151);
            button1.Name = "button1";
            button1.Size = new Size(108, 63);
            button1.TabIndex = 16;
            button1.Text = "Vazgeç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSifreyiGuncelle
            // 
            btnSifreyiGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSifreyiGuncelle.BackColor = Color.FromArgb(255, 128, 0);
            btnSifreyiGuncelle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSifreyiGuncelle.Location = new Point(658, 32);
            btnSifreyiGuncelle.Name = "btnSifreyiGuncelle";
            btnSifreyiGuncelle.Size = new Size(139, 79);
            btnSifreyiGuncelle.TabIndex = 13;
            btnSifreyiGuncelle.Text = "Şifreyi Güncelle";
            btnSifreyiGuncelle.UseVisualStyleBackColor = false;
            btnSifreyiGuncelle.Click += btnSifreyiGuncelle_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYeniSifreTekrar.BackColor = Color.FromArgb(255, 128, 0);
            txtYeniSifreTekrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniSifreTekrar.Location = new Point(346, 90);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(254, 35);
            txtYeniSifreTekrar.TabIndex = 15;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtYeniSifre.BackColor = Color.FromArgb(255, 128, 0);
            txtYeniSifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniSifre.Location = new Point(346, 22);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(254, 35);
            txtYeniSifre.TabIndex = 14;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label6.Location = new Point(63, 85);
            label6.Name = "label6";
            label6.Size = new Size(255, 40);
            label6.TabIndex = 12;
            label6.Text = "Yeni Şifre Tekrar :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(157, 17);
            label5.Name = "label5";
            label5.Size = new Size(161, 40);
            label5.TabIndex = 11;
            label5.Text = "Yeni Şifre :";
            // 
            // FrmSifremiUnuttumAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 682);
            Controls.Add(panelSifreGuncelle);
            Controls.Add(panelKoduDogrula);
            Controls.Add(panelKodGonder);
            Name = "FrmSifremiUnuttumAdmin";
            Text = "FrmSifremiUnuttumAdmin";
            Load += FrmSifremiUnuttumAdmin_Load;
            panelKodGonder.ResumeLayout(false);
            panelKodGonder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelKoduDogrula.ResumeLayout(false);
            panelKoduDogrula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelSifreGuncelle.ResumeLayout(false);
            panelSifreGuncelle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelKodGonder;
        private Panel panelKoduDogrula;
        private Panel panelSifreGuncelle;
        private PictureBox pictureBox1;
        private Button btnGeri;
        private Button btnKodGonder;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button2;
        private Button btnKoduDogrula;
        private TextBox txtKod;
        private Label label3;
        private Label lblOtpBilgi;
        private Button button1;
        private Button btnSifreyiGuncelle;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private Label label6;
        private Label label5;
    }
}