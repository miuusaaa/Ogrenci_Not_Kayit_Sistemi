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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmenIslemleri));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label12 = new Label();
            txtFilterOgretmen = new TextBox();
            dgvOgretmenler = new DataGridView();
            btnAktiflikKaydet = new Button();
            btnOgretmenSil = new Button();
            panel2 = new Panel();
            label11 = new Label();
            txtKullaniciAdi = new TextBox();
            label9 = new Label();
            txtOgretmenTelefon = new TextBox();
            label8 = new Label();
            txtOgretmenEmail = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            clbSiniflar = new CheckedListBox();
            cmbOkullar = new ComboBox();
            cmbBranslar = new ComboBox();
            btnOgretmenEkle = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txtOgretmenSoyad = new TextBox();
            label3 = new Label();
            txtOgretmenAd = new TextBox();
            panel4 = new Panel();
            clbGuncelSiniflar = new CheckedListBox();
            panel5 = new Panel();
            label10 = new Label();
            label13 = new Label();
            txtGuncelKullaniciAdi = new TextBox();
            cmbGuncelOkullar = new ComboBox();
            cmbGuncelBranslar = new ComboBox();
            label15 = new Label();
            txtGuncelTelefon = new TextBox();
            label16 = new Label();
            txtGuncelEmail = new TextBox();
            label18 = new Label();
            label19 = new Label();
            btnOgretmenGuncelle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgretmenler).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(txtFilterOgretmen);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 48);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(312, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(381, 10);
            label12.Name = "label12";
            label12.Size = new Size(117, 21);
            label12.TabIndex = 38;
            label12.Text = "Öğretmen Ara";
            // 
            // txtFilterOgretmen
            // 
            txtFilterOgretmen.Location = new Point(510, 12);
            txtFilterOgretmen.Name = "txtFilterOgretmen";
            txtFilterOgretmen.Size = new Size(238, 23);
            txtFilterOgretmen.TabIndex = 37;
            txtFilterOgretmen.TextChanged += txtFilterOgretmen_TextChanged;
            // 
            // dgvOgretmenler
            // 
            dgvOgretmenler.AllowUserToAddRows = false;
            dgvOgretmenler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgretmenler.BackgroundColor = SystemColors.ActiveCaption;
            dgvOgretmenler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgretmenler.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvOgretmenler.Location = new Point(1, 49);
            dgvOgretmenler.MultiSelect = false;
            dgvOgretmenler.Name = "dgvOgretmenler";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LawnGreen;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOgretmenler.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOgretmenler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgretmenler.Size = new Size(854, 204);
            dgvOgretmenler.TabIndex = 3;
            dgvOgretmenler.CellClick += dgvOgretmenler_CellClick;
            // 
            // btnAktiflikKaydet
            // 
            btnAktiflikKaydet.BackColor = Color.Fuchsia;
            btnAktiflikKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAktiflikKaydet.Location = new Point(851, 148);
            btnAktiflikKaydet.Name = "btnAktiflikKaydet";
            btnAktiflikKaydet.Size = new Size(196, 105);
            btnAktiflikKaydet.TabIndex = 55;
            btnAktiflikKaydet.Text = "Aktif-Pasif Değişikliklerini Kaydet";
            btnAktiflikKaydet.UseVisualStyleBackColor = false;
            btnAktiflikKaydet.Click += btnAktiflikKaydet_Click;
            // 
            // btnOgretmenSil
            // 
            btnOgretmenSil.BackColor = Color.Yellow;
            btnOgretmenSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOgretmenSil.Location = new Point(851, 49);
            btnOgretmenSil.Name = "btnOgretmenSil";
            btnOgretmenSil.Size = new Size(196, 103);
            btnOgretmenSil.TabIndex = 56;
            btnOgretmenSil.Text = "Seçili Öğretmeni Sil";
            btnOgretmenSil.UseVisualStyleBackColor = false;
            btnOgretmenSil.Click += btnOgretmenSil_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtKullaniciAdi);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtOgretmenTelefon);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtOgretmenEmail);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(clbSiniflar);
            panel2.Controls.Add(cmbOkullar);
            panel2.Controls.Add(cmbBranslar);
            panel2.Controls.Add(btnOgretmenEkle);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtOgretmenSoyad);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtOgretmenAd);
            panel2.Location = new Point(1, 252);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 444);
            panel2.TabIndex = 61;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(16, 180);
            label11.Name = "label11";
            label11.Size = new Size(115, 21);
            label11.TabIndex = 82;
            label11.Text = "Kullanıcı Adı :";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(155, 182);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(201, 23);
            txtKullaniciAdi.TabIndex = 81;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(56, 241);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 80;
            label9.Text = "Telefon :";
            // 
            // txtOgretmenTelefon
            // 
            txtOgretmenTelefon.Location = new Point(155, 244);
            txtOgretmenTelefon.Name = "txtOgretmenTelefon";
            txtOgretmenTelefon.Size = new Size(201, 23);
            txtOgretmenTelefon.TabIndex = 79;
            txtOgretmenTelefon.Text = "+90";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(70, 215);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 78;
            label8.Text = "Email :";
            // 
            // txtOgretmenEmail
            // 
            txtOgretmenEmail.Location = new Point(155, 215);
            txtOgretmenEmail.Name = "txtOgretmenEmail";
            txtOgretmenEmail.Size = new Size(201, 23);
            txtOgretmenEmail.TabIndex = 77;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 0);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 48);
            panel3.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(109, 5);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 74;
            label2.Text = "Öğretmen Ekle";
            // 
            // clbSiniflar
            // 
            clbSiniflar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clbSiniflar.FormattingEnabled = true;
            clbSiniflar.Location = new Point(11, 280);
            clbSiniflar.Name = "clbSiniflar";
            clbSiniflar.Size = new Size(355, 76);
            clbSiniflar.TabIndex = 72;
            // 
            // cmbOkullar
            // 
            cmbOkullar.FormattingEnabled = true;
            cmbOkullar.Location = new Point(155, 114);
            cmbOkullar.Name = "cmbOkullar";
            cmbOkullar.Size = new Size(201, 23);
            cmbOkullar.TabIndex = 71;
            cmbOkullar.SelectedIndexChanged += cmbOkullar_SelectedIndexChanged;
            // 
            // cmbBranslar
            // 
            cmbBranslar.FormattingEnabled = true;
            cmbBranslar.Location = new Point(155, 143);
            cmbBranslar.Name = "cmbBranslar";
            cmbBranslar.Size = new Size(201, 23);
            cmbBranslar.TabIndex = 70;
            cmbBranslar.SelectedIndexChanged += cmbBranslar_SelectedIndexChanged;
            // 
            // btnOgretmenEkle
            // 
            btnOgretmenEkle.BackColor = Color.FromArgb(255, 224, 192);
            btnOgretmenEkle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOgretmenEkle.Location = new Point(7, 369);
            btnOgretmenEkle.Name = "btnOgretmenEkle";
            btnOgretmenEkle.Size = new Size(359, 62);
            btnOgretmenEkle.TabIndex = 69;
            btnOgretmenEkle.Text = "Öğretmen ekle";
            btnOgretmenEkle.UseVisualStyleBackColor = false;
            btnOgretmenEkle.Click += btnOgretmenEkle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(11, 116);
            label6.Name = "label6";
            label6.Size = new Size(120, 21);
            label6.TabIndex = 64;
            label6.Text = "Çalıştığı Okul :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(66, 144);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 63;
            label5.Text = "Branşı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(61, 84);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 62;
            label4.Text = "Soyadı :";
            // 
            // txtOgretmenSoyad
            // 
            txtOgretmenSoyad.Location = new Point(155, 84);
            txtOgretmenSoyad.Name = "txtOgretmenSoyad";
            txtOgretmenSoyad.Size = new Size(201, 23);
            txtOgretmenSoyad.TabIndex = 61;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 53);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 60;
            label3.Text = "Öğretmen Adı :";
            // 
            // txtOgretmenAd
            // 
            txtOgretmenAd.Location = new Point(155, 55);
            txtOgretmenAd.Name = "txtOgretmenAd";
            txtOgretmenAd.Size = new Size(201, 23);
            txtOgretmenAd.TabIndex = 59;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 255, 255);
            panel4.Controls.Add(clbGuncelSiniflar);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(txtGuncelKullaniciAdi);
            panel4.Controls.Add(cmbGuncelOkullar);
            panel4.Controls.Add(cmbGuncelBranslar);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtGuncelTelefon);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(txtGuncelEmail);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(label19);
            panel4.Controls.Add(btnOgretmenGuncelle);
            panel4.Location = new Point(382, 255);
            panel4.Name = "panel4";
            panel4.Size = new Size(667, 440);
            panel4.TabIndex = 62;
            // 
            // clbGuncelSiniflar
            // 
            clbGuncelSiniflar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clbGuncelSiniflar.FormattingEnabled = true;
            clbGuncelSiniflar.Location = new Point(38, 277);
            clbGuncelSiniflar.Name = "clbGuncelSiniflar";
            clbGuncelSiniflar.Size = new Size(599, 76);
            clbGuncelSiniflar.TabIndex = 88;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 192, 192);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(0, -3);
            panel5.Name = "panel5";
            panel5.Size = new Size(664, 49);
            panel5.TabIndex = 87;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label10.Location = new Point(270, 6);
            label10.Name = "label10";
            label10.Size = new Size(203, 30);
            label10.TabIndex = 72;
            label10.Text = "Öğretmen Güncelle";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(109, 138);
            label13.Name = "label13";
            label13.Size = new Size(115, 21);
            label13.TabIndex = 86;
            label13.Text = "Kullanıcı Adı :";
            // 
            // txtGuncelKullaniciAdi
            // 
            txtGuncelKullaniciAdi.Location = new Point(272, 140);
            txtGuncelKullaniciAdi.Name = "txtGuncelKullaniciAdi";
            txtGuncelKullaniciAdi.Size = new Size(328, 23);
            txtGuncelKullaniciAdi.TabIndex = 85;
            // 
            // cmbGuncelOkullar
            // 
            cmbGuncelOkullar.FormattingEnabled = true;
            cmbGuncelOkullar.Location = new Point(272, 56);
            cmbGuncelOkullar.Name = "cmbGuncelOkullar";
            cmbGuncelOkullar.Size = new Size(326, 23);
            cmbGuncelOkullar.TabIndex = 83;
            cmbGuncelOkullar.Click += cmbGuncelOkullar_SelectedIndexChanged;
            // 
            // cmbGuncelBranslar
            // 
            cmbGuncelBranslar.FormattingEnabled = true;
            cmbGuncelBranslar.Location = new Point(272, 95);
            cmbGuncelBranslar.Name = "cmbGuncelBranslar";
            cmbGuncelBranslar.Size = new Size(326, 23);
            cmbGuncelBranslar.TabIndex = 82;
            cmbGuncelBranslar.Click += cmbGuncelBranslar_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label15.Location = new Point(149, 225);
            label15.Name = "label15";
            label15.Size = new Size(75, 21);
            label15.TabIndex = 81;
            label15.Text = "Telefon :";
            // 
            // txtGuncelTelefon
            // 
            txtGuncelTelefon.Location = new Point(272, 227);
            txtGuncelTelefon.Name = "txtGuncelTelefon";
            txtGuncelTelefon.Size = new Size(326, 23);
            txtGuncelTelefon.TabIndex = 80;
            txtGuncelTelefon.Text = "+90";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label16.Location = new Point(163, 180);
            label16.Name = "label16";
            label16.Size = new Size(61, 21);
            label16.TabIndex = 79;
            label16.Text = "Email :";
            // 
            // txtGuncelEmail
            // 
            txtGuncelEmail.Location = new Point(272, 180);
            txtGuncelEmail.Name = "txtGuncelEmail";
            txtGuncelEmail.Size = new Size(326, 23);
            txtGuncelEmail.TabIndex = 78;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label18.Location = new Point(104, 54);
            label18.Name = "label18";
            label18.Size = new Size(120, 21);
            label18.TabIndex = 77;
            label18.Text = "Çalıştığı Okul :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label19.Location = new Point(159, 93);
            label19.Name = "label19";
            label19.Size = new Size(65, 21);
            label19.TabIndex = 76;
            label19.Text = "Branşı :";
            // 
            // btnOgretmenGuncelle
            // 
            btnOgretmenGuncelle.BackColor = Color.FromArgb(128, 255, 255);
            btnOgretmenGuncelle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOgretmenGuncelle.Location = new Point(38, 366);
            btnOgretmenGuncelle.Name = "btnOgretmenGuncelle";
            btnOgretmenGuncelle.Size = new Size(599, 62);
            btnOgretmenGuncelle.TabIndex = 75;
            btnOgretmenGuncelle.Text = "      Öğretmen Güncelle";
            btnOgretmenGuncelle.UseVisualStyleBackColor = false;
            btnOgretmenGuncelle.Click += btnOgretmenGuncelle_Click;
            // 
            // FrmOgretmenIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 695);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(btnOgretmenSil);
            Controls.Add(btnAktiflikKaydet);
            Controls.Add(dgvOgretmenler);
            Controls.Add(panel1);
            Name = "FrmOgretmenIslemleri";
            Text = "FrmOgretmenIslemleri";
            Load += FrmOgretmenIslemleri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgretmenler).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvOgretmenler;
        private Button btnAktiflikKaydet;
        private Button btnOgretmenSil;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private CheckedListBox clbSiniflar;
        private ComboBox cmbOkullar;
        private ComboBox cmbBranslar;
        private Button btnOgretmenEkle;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtOgretmenSoyad;
        private Label label3;
        private TextBox txtOgretmenAd;
        private Label label12;
        private TextBox txtFilterOgretmen;
        private Panel panel4;
        private Panel panel5;
        private Label label10;
        private Label label13;
        private TextBox txtGuncelKullaniciAdi;
        private ComboBox cmbGuncelOkullar;
        private ComboBox cmbGuncelBranslar;
        private Label label15;
        private TextBox txtGuncelTelefon;
        private Label label16;
        private TextBox txtGuncelEmail;
        private Label label18;
        private Label label19;
        private Button btnOgretmenGuncelle;
        private Label label11;
        private TextBox txtKullaniciAdi;
        private Label label9;
        private TextBox txtOgretmenTelefon;
        private Label label8;
        private TextBox txtOgretmenEmail;
        private CheckedListBox clbGuncelSiniflar;
        private PictureBox pictureBox1;
    }
}