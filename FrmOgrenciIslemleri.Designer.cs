namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgrenciIslemleri
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
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            txtOgrNo = new TextBox();
            label2 = new Label();
            txtOgrAd = new TextBox();
            label3 = new Label();
            txtOgrSoyad = new TextBox();
            label4 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtTC = new TextBox();
            dtpDogumTarihi = new DateTimePicker();
            label1 = new Label();
            label5 = new Label();
            label9 = new Label();
            txtTelefon = new TextBox();
            pbFotograf = new PictureBox();
            label10 = new Label();
            cmbSinif = new ComboBox();
            txtFilter = new TextBox();
            label11 = new Label();
            btnFotoSil = new Button();
            btnFotoYukle = new Button();
            cmbOkulu = new ComboBox();
            label12 = new Label();
            cmbGuncelOkul = new ComboBox();
            label13 = new Label();
            cmbGuncelSinif = new ComboBox();
            label14 = new Label();
            txtGuncelTelefon = new TextBox();
            label16 = new Label();
            txtGuncelEmail = new TextBox();
            label17 = new Label();
            label18 = new Label();
            txtGuncelOgrNo = new TextBox();
            dgvOgrenciler = new DataGridView();
            btnAktiflikKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(142, 735);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 43);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Öğrenci Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(508, 665);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 43);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Öğrenci Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnUpdate_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(955, -1);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(172, 186);
            btnSil.TabIndex = 3;
            btnSil.Text = "Seçili öğrenciyi sistemden sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnDelete_Click;
            // 
            // txtOgrNo
            // 
            txtOgrNo.Location = new Point(183, 603);
            txtOgrNo.Name = "txtOgrNo";
            txtOgrNo.Size = new Size(100, 23);
            txtOgrNo.TabIndex = 4;
            txtOgrNo.KeyPress += txtOgrNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 394);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "Ad";
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(172, 394);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(100, 23);
            txtOgrAd.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 427);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Soyad";
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(172, 427);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(100, 23);
            txtOgrSoyad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(103, 679);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "Sınıf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(91, 562);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(182, 559);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(96, 491);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 17;
            label7.Text = "TC";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(172, 485);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 16;
            txtTC.KeyPress += txtTC_KeyPress;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(182, 456);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(79, 23);
            dtpDogumTarihi.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 606);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(81, 456);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 21;
            label5.Text = "Doğum Tarihi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(91, 525);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 23;
            label9.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(182, 525);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 22;
            txtTelefon.Text = "+90";
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            // 
            // pbFotograf
            // 
            pbFotograf.Location = new Point(518, 391);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(90, 50);
            pbFotograf.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotograf.TabIndex = 24;
            pbFotograf.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(411, 404);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 25;
            label10.Text = "Fotoğraf";
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(183, 676);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(100, 23);
            cmbSinif.TabIndex = 26;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(683, 786);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(100, 23);
            txtFilter.TabIndex = 27;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(621, 789);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 28;
            label11.Text = "Ara";
            // 
            // btnFotoSil
            // 
            btnFotoSil.Location = new Point(619, 424);
            btnFotoSil.Name = "btnFotoSil";
            btnFotoSil.Size = new Size(80, 31);
            btnFotoSil.TabIndex = 30;
            btnFotoSil.Text = "Fotoğrafı Sil";
            btnFotoSil.UseVisualStyleBackColor = true;
            btnFotoSil.Click += btnFotoSil_Click;
            // 
            // btnFotoYukle
            // 
            btnFotoYukle.Location = new Point(621, 385);
            btnFotoYukle.Name = "btnFotoYukle";
            btnFotoYukle.Size = new Size(78, 34);
            btnFotoYukle.TabIndex = 29;
            btnFotoYukle.Text = "Yükle";
            btnFotoYukle.UseVisualStyleBackColor = true;
            btnFotoYukle.Click += btnFotoYukle_Click;
            // 
            // cmbOkulu
            // 
            cmbOkulu.FormattingEnabled = true;
            cmbOkulu.Location = new Point(183, 641);
            cmbOkulu.Name = "cmbOkulu";
            cmbOkulu.Size = new Size(100, 23);
            cmbOkulu.TabIndex = 32;
            cmbOkulu.SelectedIndexChanged += cmbOkulu_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(99, 644);
            label12.Name = "label12";
            label12.Size = new Size(39, 15);
            label12.TabIndex = 31;
            label12.Text = "Okulu";
            // 
            // cmbGuncelOkul
            // 
            cmbGuncelOkul.FormattingEnabled = true;
            cmbGuncelOkul.Location = new Point(508, 579);
            cmbGuncelOkul.Name = "cmbGuncelOkul";
            cmbGuncelOkul.Size = new Size(100, 23);
            cmbGuncelOkul.TabIndex = 44;
            cmbGuncelOkul.SelectedIndexChanged += cmbGuncelOkul_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(424, 582);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 43;
            label13.Text = "Okulu";
            // 
            // cmbGuncelSinif
            // 
            cmbGuncelSinif.FormattingEnabled = true;
            cmbGuncelSinif.Location = new Point(508, 614);
            cmbGuncelSinif.Name = "cmbGuncelSinif";
            cmbGuncelSinif.Size = new Size(100, 23);
            cmbGuncelSinif.TabIndex = 42;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(417, 459);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 41;
            label14.Text = "Telefon";
            // 
            // txtGuncelTelefon
            // 
            txtGuncelTelefon.Location = new Point(508, 459);
            txtGuncelTelefon.Name = "txtGuncelTelefon";
            txtGuncelTelefon.Size = new Size(100, 23);
            txtGuncelTelefon.TabIndex = 40;
            txtGuncelTelefon.Text = "+90";
            txtGuncelTelefon.KeyPress += txtGuncelTelefon_KeyPress;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(422, 496);
            label16.Name = "label16";
            label16.Size = new Size(41, 15);
            label16.TabIndex = 37;
            label16.Text = "E-mail";
            // 
            // txtGuncelEmail
            // 
            txtGuncelEmail.Location = new Point(508, 493);
            txtGuncelEmail.Name = "txtGuncelEmail";
            txtGuncelEmail.Size = new Size(100, 23);
            txtGuncelEmail.TabIndex = 36;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(433, 617);
            label17.Name = "label17";
            label17.Size = new Size(30, 15);
            label17.TabIndex = 35;
            label17.Text = "Sınıf";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(395, 544);
            label18.Name = "label18";
            label18.Size = new Size(68, 15);
            label18.TabIndex = 34;
            label18.Text = "Öğrenci No";
            // 
            // txtGuncelOgrNo
            // 
            txtGuncelOgrNo.Location = new Point(508, 541);
            txtGuncelOgrNo.Name = "txtGuncelOgrNo";
            txtGuncelOgrNo.Size = new Size(100, 23);
            txtGuncelOgrNo.TabIndex = 33;
            txtGuncelOgrNo.KeyPress += txtGuncelOgrNo_KeyPress;
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AllowUserToAddRows = false;
            dgvOgrenciler.AllowUserToDeleteRows = false;
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciler.CausesValidation = false;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Location = new Point(-1, -1);
            dgvOgrenciler.MultiSelect = false;
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.ReadOnly = true;
            dgvOgrenciler.RowHeadersVisible = false;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.Size = new Size(950, 356);
            dgvOgrenciler.TabIndex = 45;
            // 
            // btnAktiflikKaydet
            // 
            btnAktiflikKaydet.Location = new Point(955, 180);
            btnAktiflikKaydet.Name = "btnAktiflikKaydet";
            btnAktiflikKaydet.Size = new Size(172, 175);
            btnAktiflikKaydet.TabIndex = 46;
            btnAktiflikKaydet.Text = "Seçili öğrencileri Aktif/Pasif Yap";
            btnAktiflikKaydet.UseVisualStyleBackColor = true;
            btnAktiflikKaydet.Click += btnAktiflikKaydet_Click;
            // 
            // FrmOgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1129, 833);
            Controls.Add(btnAktiflikKaydet);
            Controls.Add(dgvOgrenciler);
            Controls.Add(cmbGuncelOkul);
            Controls.Add(label13);
            Controls.Add(cmbGuncelSinif);
            Controls.Add(label14);
            Controls.Add(txtGuncelTelefon);
            Controls.Add(label16);
            Controls.Add(txtGuncelEmail);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(txtGuncelOgrNo);
            Controls.Add(cmbOkulu);
            Controls.Add(label12);
            Controls.Add(btnFotoSil);
            Controls.Add(btnFotoYukle);
            Controls.Add(label11);
            Controls.Add(txtFilter);
            Controls.Add(cmbSinif);
            Controls.Add(label10);
            Controls.Add(pbFotograf);
            Controls.Add(label9);
            Controls.Add(txtTelefon);
            Controls.Add(label5);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(label7);
            Controls.Add(txtTC);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtOgrSoyad);
            Controls.Add(label2);
            Controls.Add(txtOgrAd);
            Controls.Add(label1);
            Controls.Add(txtOgrNo);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Name = "FrmOgrenciIslemleri";
            Text = "Ara";
            Load += FrmOgrenciListe_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOgrenciler;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private TextBox txtOgrNo;
        private Label label2;
        private TextBox txtOgrAd;
        private Label label3;
        private TextBox txtOgrSoyad;
        private Label label4;
        private TextBox textBox5;
        private Label label6;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtTC;
        private Label label8;
        private TextBox txtSifreHash;
        private DateTimePicker dtpDogumTarihi;
        private Label label1;
        private Label label5;
        private Label label9;
        private TextBox txtTelefon;
        private PictureBox pbFotograf;
        private Label label10;
        private ComboBox cmbSinif;
        private TextBox txtFilter;
        private Label label11;
        private Button btnFotoSil;
        private Button btnFotoYukle;
        private ComboBox cmbOkulu;
        private Label label12;
        private ComboBox cmbGuncelOkul;
        private Label label13;
        private ComboBox cmbGuncelSinif;
        private Label label14;
        private TextBox txtGuncelTelefon;
        private Label label15;
        private TextBox txtGuncelSifre;
        private Label label16;
        private TextBox txtGuncelEmail;
        private Label label17;
        private Label label18;
        private TextBox txtGuncelOgrNo;
        private Button btnAktiflikKaydet;
    }
}