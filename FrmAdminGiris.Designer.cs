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
            panel1 = new Panel();
            webViewRecaptcha = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtRecaptchaToken = new TextBox();
            lblBilgi = new Label();
            btnOTPGonder = new Button();
            txtOTP = new TextBox();
            btnGiris = new Button();
            label3 = new Label();
            txtCaptcha = new TextBox();
            label2 = new Label();
            txtSifre = new TextBox();
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewRecaptcha).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(webViewRecaptcha);
            panel1.Controls.Add(txtRecaptchaToken);
            panel1.Controls.Add(lblBilgi);
            panel1.Controls.Add(btnOTPGonder);
            panel1.Controls.Add(txtOTP);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCaptcha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 454);
            panel1.TabIndex = 8;
            // 
            // webViewRecaptcha
            // 
            webViewRecaptcha.AllowExternalDrop = true;
            webViewRecaptcha.CreationProperties = null;
            webViewRecaptcha.DefaultBackgroundColor = Color.White;
            webViewRecaptcha.Location = new Point(68, 186);
            webViewRecaptcha.Name = "webViewRecaptcha";
            webViewRecaptcha.Size = new Size(299, 98);
            webViewRecaptcha.TabIndex = 20;
            webViewRecaptcha.ZoomFactor = 1D;
            // 
            // txtRecaptchaToken
            // 
            txtRecaptchaToken.Anchor = AnchorStyles.None;
            txtRecaptchaToken.HideSelection = false;
            txtRecaptchaToken.Location = new Point(789, 431);
            txtRecaptchaToken.Name = "txtRecaptchaToken";
            txtRecaptchaToken.Size = new Size(10, 23);
            txtRecaptchaToken.TabIndex = 19;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblBilgi.Location = new Point(329, 373);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(120, 50);
            lblBilgi.TabIndex = 18;
            lblBilgi.Text = "label4";
            // 
            // btnOTPGonder
            // 
            btnOTPGonder.Anchor = AnchorStyles.None;
            btnOTPGonder.Location = new Point(475, 326);
            btnOTPGonder.Name = "btnOTPGonder";
            btnOTPGonder.Size = new Size(75, 23);
            btnOTPGonder.TabIndex = 17;
            btnOTPGonder.Text = "Gönder";
            btnOTPGonder.UseVisualStyleBackColor = true;
            btnOTPGonder.Click += btnOTPGonder_Click;
            // 
            // txtOTP
            // 
            txtOTP.Anchor = AnchorStyles.None;
            txtOTP.Location = new Point(290, 327);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(100, 23);
            txtOTP.TabIndex = 16;
            // 
            // btnGiris
            // 
            btnGiris.Anchor = AnchorStyles.None;
            btnGiris.Location = new Point(464, 61);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 23);
            btnGiris.TabIndex = 14;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 177);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 13;
            // 
            // txtCaptcha
            // 
            txtCaptcha.Anchor = AnchorStyles.None;
            txtCaptcha.Location = new Point(439, 214);
            txtCaptcha.Name = "txtCaptcha";
            txtCaptcha.Size = new Size(100, 23);
            txtCaptcha.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(172, 107);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 11;
            label2.Text = "Şifre :";
            // 
            // txtSifre
            // 
            txtSifre.Anchor = AnchorStyles.None;
            txtSifre.Location = new Point(245, 104);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(100, 23);
            txtSifre.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(131, 39);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 9;
            label1.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Anchor = AnchorStyles.None;
            txtKullaniciAdi.Location = new Point(245, 36);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(100, 23);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "FrmAdminGiris";
            Text = "FrmAdminGiris";
            Load += FrmAdminGiris_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webViewRecaptcha).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGiris;
        private Label label3;
        private TextBox txtCaptcha;
        private Label label2;
        private TextBox txtSifre;
        private Label label1;
        private TextBox txtKullaniciAdi;
        private TextBox txtOTP;
        private Label lblBilgi;
        private Button btnOTPGonder;
        private TextBox txtRecaptchaToken;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewRecaptcha;
    }
}