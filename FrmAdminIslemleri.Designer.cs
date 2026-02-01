namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmAdminIslemleri
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
            label1 = new Label();
            btnAdminEkle = new Button();
            txtKullaniciAdi = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtTelefon = new TextBox();
            label3 = new Label();
            btnAdminSil = new Button();
            dgvAdminler = new DataGridView();
            btnAktiflikKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdminler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(142, 170);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // btnAdminEkle
            // 
            btnAdminEkle.BackColor = Color.FromArgb(0, 192, 192);
            btnAdminEkle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            btnAdminEkle.Location = new Point(279, 387);
            btnAdminEkle.Name = "btnAdminEkle";
            btnAdminEkle.Size = new Size(276, 54);
            btnAdminEkle.TabIndex = 4;
            btnAdminEkle.Text = "Admini Sisteme Ekle";
            btnAdminEkle.UseVisualStyleBackColor = false;
            btnAdminEkle.Click += btnAdminEkle_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.Lime;
            txtKullaniciAdi.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txtKullaniciAdi.Location = new Point(354, 170);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(298, 39);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Lime;
            txtEmail.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txtEmail.Location = new Point(354, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(298, 39);
            txtEmail.TabIndex = 2;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(224, 243);
            label2.Name = "label2";
            label2.Size = new Size(93, 32);
            label2.TabIndex = 3;
            label2.Text = "Email :";
            // 
            // txtTelefon
            // 
            txtTelefon.BackColor = Color.Lime;
            txtTelefon.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            txtTelefon.Location = new Point(354, 312);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(298, 39);
            txtTelefon.TabIndex = 3;
            txtTelefon.Text = "+90";
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            txtTelefon.Leave += txtTelefon_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(206, 315);
            label3.Name = "label3";
            label3.Size = new Size(111, 32);
            label3.TabIndex = 5;
            label3.Text = "Telefon :";
            // 
            // btnAdminSil
            // 
            btnAdminSil.BackColor = Color.Cornsilk;
            btnAdminSil.Location = new Point(660, -2);
            btnAdminSil.Name = "btnAdminSil";
            btnAdminSil.Size = new Size(142, 78);
            btnAdminSil.TabIndex = 0;
            btnAdminSil.Text = "Seçilen Admini Sistemden Sil\r\n";
            btnAdminSil.UseVisualStyleBackColor = false;
            btnAdminSil.Click += btnAdminSil_Click;
            // 
            // dgvAdminler
            // 
            dgvAdminler.AllowUserToAddRows = false;
            dgvAdminler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminler.GridColor = Color.PaleGreen;
            dgvAdminler.Location = new Point(-2, -2);
            dgvAdminler.Name = "dgvAdminler";
            dgvAdminler.ReadOnly = true;
            dgvAdminler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminler.Size = new Size(665, 146);
            dgvAdminler.TabIndex = 8;
            dgvAdminler.CellClick += dgvAdminler_CellClick;
            // 
            // btnAktiflikKaydet
            // 
            btnAktiflikKaydet.BackColor = Color.FromArgb(255, 128, 0);
            btnAktiflikKaydet.Location = new Point(660, 74);
            btnAktiflikKaydet.Name = "btnAktiflikKaydet";
            btnAktiflikKaydet.Size = new Size(142, 70);
            btnAktiflikKaydet.TabIndex = 9;
            btnAktiflikKaydet.Text = "Aktif/Pasif değişikliklerini uygula";
            btnAktiflikKaydet.UseVisualStyleBackColor = false;
            btnAktiflikKaydet.Click += btnAktiflikKaydet_Click;
            // 
            // FrmAdminIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 463);
            Controls.Add(btnAktiflikKaydet);
            Controls.Add(dgvAdminler);
            Controls.Add(btnAdminSil);
            Controls.Add(txtTelefon);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnAdminEkle);
            Controls.Add(label1);
            Name = "FrmAdminIslemleri";
            Text = "FrmAdminIslemleri";
            Load += FrmAdminIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdminler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAdminEkle;
        private TextBox txtKullaniciAdi;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtTelefon;
        private Label label3;
        private Button btnAdminSil;
        private DataGridView dgvAdminler;
        private Button btnAktiflikKaydet;
    }
}