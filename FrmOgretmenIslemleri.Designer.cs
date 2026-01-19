namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgretmenIslemleri
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
            label1 = new Label();
            dgvOgretmenler = new DataGridView();
            txtOgretmenAd = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtOgretmenSoyad = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtOgretmenEmail = new TextBox();
            label9 = new Label();
            txtOgretmenTelefon = new TextBox();
            btnOgretmenGuncelle = new Button();
            btnOgretmenEkle = new Button();
            cmbBranslar = new ComboBox();
            cmbOkullar = new ComboBox();
            label12 = new Label();
            txtFilterOgretmen = new TextBox();
            cmbGuncelOkullar = new ComboBox();
            cmbGuncelBranslar = new ComboBox();
            label15 = new Label();
            txtGuncelTelefon = new TextBox();
            label16 = new Label();
            txtGuncelEmail = new TextBox();
            label18 = new Label();
            label19 = new Label();
            clbSiniflar = new CheckedListBox();
            clbGuncelSiniflar = new CheckedListBox();
            label2 = new Label();
            label10 = new Label();
            btnAktiflikKaydet = new Button();
            btnOgretmenSil = new Button();
            label11 = new Label();
            txtKullaniciAdi = new TextBox();
            label13 = new Label();
            txtGuncelKullaniciAdi = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgretmenler).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 48);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(461, 9);
            label1.Name = "label1";
            label1.Size = new Size(167, 37);
            label1.TabIndex = 0;
            label1.Text = "Öğretmenler";
            // 
            // dgvOgretmenler
            // 
            dgvOgretmenler.AllowUserToAddRows = false;
            dgvOgretmenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgretmenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgretmenler.Location = new Point(1, 49);
            dgvOgretmenler.MultiSelect = false;
            dgvOgretmenler.Name = "dgvOgretmenler";
            dgvOgretmenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgretmenler.Size = new Size(1046, 204);
            dgvOgretmenler.TabIndex = 3;
            dgvOgretmenler.CellClick += dgvOgretmenler_CellClick;
            // 
            // txtOgretmenAd
            // 
            txtOgretmenAd.Location = new Point(135, 308);
            txtOgretmenAd.Name = "txtOgretmenAd";
            txtOgretmenAd.Size = new Size(75, 23);
            txtOgretmenAd.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 311);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 6;
            label3.Text = "Öğretmen Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 340);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 8;
            label4.Text = "Soyadı :";
            // 
            // txtOgretmenSoyad
            // 
            txtOgretmenSoyad.Location = new Point(135, 337);
            txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            txtOgretmenSoyad.Size = new Size(75, 23);
            txtOgretmenSoyad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 399);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 10;
            label5.Text = "Branşı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 371);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 12;
            label6.Text = "Çalıştığı Okul :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 566);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 16;
            label8.Text = "Email :";
            // 
            // txtOgretmenEmail
            // 
            txtOgretmenEmail.Location = new Point(135, 563);
            txtOgretmenEmail.Name = "txtOgretmenEmail";
            txtOgretmenEmail.Size = new Size(75, 23);
            txtOgretmenEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(55, 592);
            label9.Name = "label9";
            label9.Size = new Size(52, 15);
            label9.TabIndex = 18;
            label9.Text = "Telefon :";
            // 
            // txtOgretmenTelefon
            // 
            txtOgretmenTelefon.Location = new Point(135, 592);
            txtOgretmenTelefon.Name = "txtOgretmenTelefon";
            txtOgretmenTelefon.Size = new Size(75, 23);
            txtOgretmenTelefon.TabIndex = 17;
            txtOgretmenTelefon.KeyPress += txtOgretmenTelefon_KeyPress;
            // 
            // btnOgretmenGuncelle
            // 
            btnOgretmenGuncelle.Location = new Point(403, 607);
            btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            btnOgretmenGuncelle.Size = new Size(75, 41);
            btnOgretmenGuncelle.TabIndex = 31;
            btnOgretmenGuncelle.Text = "Öğretmen Güncelle";
            btnOgretmenGuncelle.UseVisualStyleBackColor = true;
            btnOgretmenGuncelle.Click += btnOgretmenGuncelle_Click;
            // 
            // btnOgretmenEkle
            // 
            btnOgretmenEkle.Location = new Point(86, 642);
            btnOgretmenEkle.Name = "btnOgretmenEkle";
            btnOgretmenEkle.Size = new Size(91, 41);
            btnOgretmenEkle.TabIndex = 30;
            btnOgretmenEkle.Text = "Öğretmen ekle";
            btnOgretmenEkle.UseVisualStyleBackColor = true;
            btnOgretmenEkle.Click += btnOgretmenEkle_Click;
            // 
            // cmbBranslar
            // 
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(135, 396);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(75, 23);
            cmbBranslar.TabIndex = 33;
            cmbBranslar.SelectedIndexChanged += cmbBranslar_SelectedIndexChanged;
            // 
            // cmbOkullar
            // 
            cmbOkullar.FormattingEnabled = true;
            cmbOkullar.Location = new Point(135, 367);
            cmbOkullar.Name = "cmbOkullar";
            cmbOkullar.Size = new Size(75, 23);
            cmbOkullar.TabIndex = 34;
            cmbOkullar.SelectedIndexChanged += cmbOkullar_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F);
            label12.Location = new Point(653, 275);
            label12.Name = "label12";
            label12.Size = new Size(131, 25);
            label12.TabIndex = 36;
            label12.Text = "Öğretmen Ara";
            // 
            // txtFilterOgretmen
            // 
            txtFilterOgretmen.Location = new Point(797, 275);
            txtFilterOgretmen.Name = "txtFilterOgretmen";
            txtFilterOgretmen.Size = new Size(171, 23);
            txtFilterOgretmen.TabIndex = 35;
            txtFilterOgretmen.TextChanged += txtFilterOgretmen_TextChanged;
            // 
            // cmbGuncelOkullar
            // 
            cmbGuncelOkullar.FormattingEnabled = true;
            cmbGuncelOkullar.Location = new Point(405, 311);
            cmbGuncelOkullar.Name = "cmbGuncelOkullar";
            cmbGuncelOkullar.Size = new Size(100, 23);
            cmbGuncelOkullar.TabIndex = 50;
            cmbGuncelOkullar.SelectedIndexChanged += cmbGuncelOkullar_SelectedIndexChanged;
            // 
            // cmbGuncelBranslar
            // 
            cmbGuncelBranslar.FormattingEnabled = true;
            cmbGuncelBranslar.Location = new Point(405, 340);
            cmbGuncelBranslar.Name = "cmbGuncelBranslar";
            cmbGuncelBranslar.Size = new Size(100, 23);
            cmbGuncelBranslar.TabIndex = 49;
            cmbGuncelBranslar.SelectedIndexChanged += cmbGuncelBranslar_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(322, 552);
            label15.Name = "label15";
            label15.Size = new Size(52, 15);
            label15.TabIndex = 48;
            label15.Text = "Telefon :";
            // 
            // txtGuncelTelefon
            // 
            txtGuncelTelefon.Location = new Point(403, 552);
            txtGuncelTelefon.Name = "txtGuncelTelefon";
            txtGuncelTelefon.Size = new Size(100, 23);
            txtGuncelTelefon.TabIndex = 47;
            txtGuncelTelefon.KeyPress += txtGuncelTelefon_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(332, 526);
            label16.Name = "label16";
            label16.Size = new Size(42, 15);
            label16.TabIndex = 46;
            label16.Text = "Email :";
            // 
            // txtGuncelEmail
            // 
            txtGuncelEmail.Location = new Point(403, 523);
            txtGuncelEmail.Name = "txtGuncelEmail";
            txtGuncelEmail.Size = new Size(100, 23);
            txtGuncelEmail.TabIndex = 45;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(294, 315);
            label18.Name = "label18";
            label18.Size = new Size(83, 15);
            label18.TabIndex = 42;
            label18.Text = "Çalıştığı Okul :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(332, 343);
            label19.Name = "label19";
            label19.Size = new Size(45, 15);
            label19.TabIndex = 41;
            label19.Text = "Branşı :";
            // 
            // clbSiniflar
            // 
            clbSiniflar.FormattingEnabled = true;
            clbSiniflar.Location = new Point(75, 440);
            clbSiniflar.Name = "clbSiniflar";
            clbSiniflar.Size = new Size(135, 76);
            clbSiniflar.TabIndex = 51;
            // 
            // clbGuncelSiniflar
            // 
            clbGuncelSiniflar.FormattingEnabled = true;
            clbGuncelSiniflar.Location = new Point(332, 371);
            clbGuncelSiniflar.Name = "clbGuncelSiniflar";
            clbGuncelSiniflar.Size = new Size(173, 94);
            clbGuncelSiniflar.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(52, 268);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 53;
            label2.Text = "Öğretmen Ekle";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(332, 273);
            label10.Name = "label10";
            label10.Size = new Size(176, 25);
            label10.TabIndex = 54;
            label10.Text = "Öğretmen Güncelle";
            // 
            // btnAktiflikKaydet
            // 
            btnAktiflikKaydet.Location = new Point(557, 386);
            btnAktiflikKaydet.Name = "btnAktiflikKaydet";
            btnAktiflikKaydet.Size = new Size(91, 41);
            btnAktiflikKaydet.TabIndex = 55;
            btnAktiflikKaydet.Text = "Aktif-Pasif Kaydet";
            btnAktiflikKaydet.UseVisualStyleBackColor = true;
            btnAktiflikKaydet.Click += btnAktiflikKaydet_Click;
            // 
            // btnOgretmenSil
            // 
            btnOgretmenSil.Location = new Point(797, 396);
            btnOgretmenSil.Name = "btnOgretmenSil";
            btnOgretmenSil.Size = new Size(160, 190);
            btnOgretmenSil.TabIndex = 56;
            btnOgretmenSil.Text = "Öğretmen sil";
            btnOgretmenSil.UseVisualStyleBackColor = true;
            btnOgretmenSil.Click += btnOgretmenSil_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 531);
            label11.Name = "label11";
            label11.Size = new Size(79, 15);
            label11.TabIndex = 58;
            label11.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(135, 528);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(75, 23);
            txtKullaniciAdi.TabIndex = 57;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(294, 484);
            label13.Name = "label13";
            label13.Size = new Size(79, 15);
            label13.TabIndex = 60;
            label13.Text = "Kullanıcı Adı :";
            // 
            // txtGuncelKullaniciAdi
            // 
            txtGuncelKullaniciAdi.Location = new Point(408, 476);
            txtGuncelKullaniciAdi.Name = "txtGuncelKullaniciAdi";
            txtGuncelKullaniciAdi.Size = new Size(95, 23);
            txtGuncelKullaniciAdi.TabIndex = 59;
            // 
            // FrmOgretmenIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 695);
            Controls.Add(label13);
            Controls.Add(txtGuncelKullaniciAdi);
            Controls.Add(label11);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnOgretmenSil);
            Controls.Add(btnAktiflikKaydet);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(clbGuncelSiniflar);
            Controls.Add(clbSiniflar);
            Controls.Add(cmbGuncelOkullar);
            Controls.Add(cmbGuncelBranslar);
            Controls.Add(label15);
            Controls.Add(txtGuncelTelefon);
            Controls.Add(label16);
            Controls.Add(txtGuncelEmail);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label12);
            Controls.Add(txtFilterOgretmen);
            Controls.Add(cmbOkullar);
            Controls.Add(cmbBranslar);
            Controls.Add(btnOgretmenGuncelle);
            Controls.Add(btnOgretmenEkle);
            Controls.Add(label9);
            Controls.Add(txtOgretmenTelefon);
            Controls.Add(label8);
            Controls.Add(txtOgretmenEmail);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtOgretmenSoyad);
            Controls.Add(label3);
            Controls.Add(txtOgretmenAd);
            Controls.Add(dgvOgretmenler);
            Controls.Add(panel1);
            Name = "FrmOgretmenIslemleri";
            Text = "FrmOgretmenIslemleri";
            Load += FrmOgretmenIslemleri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgretmenler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private DataGridView dgvOgretmenler;
        private TextBox txtOgretmenAd;
        private Label label3;
        private Label label4;
        private TextBox txtOgretmenSoyad;
        private Label label5;
        private Label label6;
        private Label label8;
        private TextBox txtOgretmenEmail;
        private Label label9;
        private TextBox txtOgretmenTelefon;
        private Button btnOgretmenGuncelle;
        private Button btnOgretmenEkle;
        private ComboBox cmbBranslar;
        private ComboBox cmbOkullar;
        private Label label12;
        private TextBox txtFilterOgretmen;
        private ComboBox cmbGuncelOkullar;
        private ComboBox cmbGuncelBranslar;
        private Label label15;
        private TextBox txtGuncelTelefon;
        private Label label16;
        private TextBox txtGuncelEmail;
        private Label label18;
        private Label label19;
        private CheckedListBox clbSiniflar;
        private CheckedListBox clbGuncelSiniflar;
        private Label label2;
        private Label label10;
        private Button btnAktiflikKaydet;
        private Button btnOgretmenSil;
        private Label label11;
        private TextBox txtKullaniciAdi;
        private Label label13;
        private TextBox txtGuncelKullaniciAdi;
    }
}