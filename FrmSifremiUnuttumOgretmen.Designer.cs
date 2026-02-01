namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmSifremiUnuttumOgretmen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSifremiUnuttumOgretmen));
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
            panelKodGonder.Controls.Add(pictureBox1);
            panelKodGonder.Controls.Add(btnGeri);
            panelKodGonder.Controls.Add(btnKodGonder);
            panelKodGonder.Controls.Add(txtKullaniciAdi);
            panelKodGonder.Controls.Add(label2);
            panelKodGonder.Controls.Add(label1);
            panelKodGonder.Dock = DockStyle.Top;
            panelKodGonder.Location = new Point(0, 0);
            panelKodGonder.Name = "panelKodGonder";
            panelKodGonder.Size = new Size(912, 249);
            panelKodGonder.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(417, 176);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btnGeri
            // 
            btnGeri.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGeri.BackColor = Color.Cyan;
            btnGeri.Location = new Point(467, 176);
            btnGeri.Name = "btnGeri";
            btnGeri.Size = new Size(82, 36);
            btnGeri.TabIndex = 19;
            btnGeri.Text = "Geri";
            btnGeri.UseVisualStyleBackColor = false;
            btnGeri.Click += btnGeri_Click;
            // 
            // btnKodGonder
            // 
            btnKodGonder.BackColor = Color.Cyan;
            btnKodGonder.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKodGonder.Location = new Point(677, 85);
            btnKodGonder.Name = "btnKodGonder";
            btnKodGonder.Size = new Size(139, 79);
            btnKodGonder.TabIndex = 3;
            btnKodGonder.Text = "Kod Gönder";
            btnKodGonder.UseVisualStyleBackColor = false;
            btnKodGonder.Click += btnKodGonder_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.Cyan;
            txtKullaniciAdi.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(365, 104);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(242, 35);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(176, 109);
            label2.Name = "label2";
            label2.Size = new Size(150, 30);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(52, 28);
            label1.Name = "label1";
            label1.Size = new Size(829, 25);
            label1.TabIndex = 0;
            label1.Text = "Lütfen kullanıcı adınızı girin . Eğer eşleşme varsa e-posta ve telefonunuza kod göndereceğiz.";
            // 
            // panelKoduDogrula
            // 
            panelKoduDogrula.Controls.Add(pictureBox2);
            panelKoduDogrula.Controls.Add(button2);
            panelKoduDogrula.Controls.Add(btnKoduDogrula);
            panelKoduDogrula.Controls.Add(txtKod);
            panelKoduDogrula.Controls.Add(label3);
            panelKoduDogrula.Controls.Add(lblOtpBilgi);
            panelKoduDogrula.Dock = DockStyle.Top;
            panelKoduDogrula.Location = new Point(0, 249);
            panelKoduDogrula.Name = "panelKoduDogrula";
            panelKoduDogrula.Size = new Size(912, 451);
            panelKoduDogrula.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 83);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(0, 115);
            button2.Name = "button2";
            button2.Size = new Size(53, 36);
            button2.TabIndex = 21;
            button2.Text = "Geri";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnKoduDogrula
            // 
            btnKoduDogrula.BackColor = Color.Cyan;
            btnKoduDogrula.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKoduDogrula.Location = new Point(572, 83);
            btnKoduDogrula.Name = "btnKoduDogrula";
            btnKoduDogrula.Size = new Size(249, 74);
            btnKoduDogrula.TabIndex = 7;
            btnKoduDogrula.Text = "Kodu Doğrula";
            btnKoduDogrula.UseVisualStyleBackColor = false;
            btnKoduDogrula.Click += btnKoduDogrula_Click;
            // 
            // txtKod
            // 
            txtKod.BackColor = Color.Cyan;
            txtKod.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKod.Location = new Point(365, 83);
            txtKod.Name = "txtKod";
            txtKod.Size = new Size(160, 71);
            txtKod.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(133, 69);
            label3.Name = "label3";
            label3.Size = new Size(192, 86);
            label3.TabIndex = 5;
            label3.Text = "Kod :";
            // 
            // lblOtpBilgi
            // 
            lblOtpBilgi.AutoSize = true;
            lblOtpBilgi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOtpBilgi.Location = new Point(133, 24);
            lblOtpBilgi.Name = "lblOtpBilgi";
            lblOtpBilgi.Size = new Size(0, 25);
            lblOtpBilgi.TabIndex = 4;
            // 
            // panelSifreGuncelle
            // 
            panelSifreGuncelle.Controls.Add(button1);
            panelSifreGuncelle.Controls.Add(btnSifreyiGuncelle);
            panelSifreGuncelle.Controls.Add(txtYeniSifreTekrar);
            panelSifreGuncelle.Controls.Add(txtYeniSifre);
            panelSifreGuncelle.Controls.Add(label6);
            panelSifreGuncelle.Controls.Add(label5);
            panelSifreGuncelle.Dock = DockStyle.Top;
            panelSifreGuncelle.Location = new Point(0, 700);
            panelSifreGuncelle.Name = "panelSifreGuncelle";
            panelSifreGuncelle.Size = new Size(912, 277);
            panelSifreGuncelle.TabIndex = 2;
            panelSifreGuncelle.Click += btnSifreyiGuncelle_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(428, 175);
            button1.Name = "button1";
            button1.Size = new Size(108, 63);
            button1.TabIndex = 10;
            button1.Text = "Vazgeç";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSifreyiGuncelle
            // 
            btnSifreyiGuncelle.BackColor = Color.Cyan;
            btnSifreyiGuncelle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSifreyiGuncelle.Location = new Point(677, 56);
            btnSifreyiGuncelle.Name = "btnSifreyiGuncelle";
            btnSifreyiGuncelle.Size = new Size(139, 79);
            btnSifreyiGuncelle.TabIndex = 8;
            btnSifreyiGuncelle.Text = "Şifreyi Güncelle";
            btnSifreyiGuncelle.UseVisualStyleBackColor = false;
            btnSifreyiGuncelle.Click += btnSifreyiGuncelle_Click;
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.BackColor = Color.Cyan;
            txtYeniSifreTekrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniSifreTekrar.Location = new Point(365, 114);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(254, 35);
            txtYeniSifreTekrar.TabIndex = 9;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.BackColor = Color.Cyan;
            txtYeniSifre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtYeniSifre.Location = new Point(365, 46);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(254, 35);
            txtYeniSifre.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            label6.Location = new Point(82, 109);
            label6.Name = "label6";
            label6.Size = new Size(255, 40);
            label6.TabIndex = 7;
            label6.Text = "Yeni Şifre Tekrar :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(176, 41);
            label5.Name = "label5";
            label5.Size = new Size(161, 40);
            label5.TabIndex = 6;
            label5.Text = "Yeni Şifre :";
            // 
            // FrmSifremiUnuttumOgretmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(912, 530);
            Controls.Add(panelSifreGuncelle);
            Controls.Add(panelKoduDogrula);
            Controls.Add(panelKodGonder);
            Name = "FrmSifremiUnuttumOgretmen";
            Text = "FrmSifremiUnuttumOgretmen";
            Load += FrmSifremiUnuttumOgretmen_Load;
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
        private Label label2;
        private Label label1;
        private Panel panelKoduDogrula;
        private Button btnKodGonder;
        private TextBox txtKullaniciAdi;
        private Button btnKoduDogrula;
        private TextBox txtKod;
        private Label label3;
        private Label lblOtpBilgi;
        private Panel panelSifreGuncelle;
        private Button btnSifreyiGuncelle;
        private TextBox txtYeniSifreTekrar;
        private TextBox txtYeniSifre;
        private Label label6;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btnGeri;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}