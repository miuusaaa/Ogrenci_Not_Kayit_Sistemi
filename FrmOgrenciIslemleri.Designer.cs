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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnSil = new Button();
            pbFotograf = new PictureBox();
            dgvOgrenciler = new DataGridView();
            btnAktiflikKaydet = new Button();
            label19 = new Label();
            panel1 = new Panel();
            btnFotoSil = new Button();
            btnFotoYukle = new Button();
            label10 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            txtTC = new TextBox();
            cmbOkulu = new ComboBox();
            label12 = new Label();
            cmbSinif = new ComboBox();
            label4 = new Label();
            btnEklenenFotoyuSil = new Button();
            btnFotoEkle = new Button();
            panel3 = new Panel();
            label20 = new Label();
            label9 = new Label();
            txtTelefon = new TextBox();
            label5 = new Label();
            dtpDogumTarihi = new DateTimePicker();
            label6 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtOgrSoyad = new TextBox();
            label2 = new Label();
            txtOgrAd = new TextBox();
            label1 = new Label();
            txtOgrNo = new TextBox();
            btnEkle = new Button();
            txtFilter = new TextBox();
            label11 = new Label();
            panel5 = new Panel();
            panel4 = new Panel();
            cmbGuncelSinif = new ComboBox();
            label8 = new Label();
            cmbGuncelOkul = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            txtGuncelTelefon = new TextBox();
            label16 = new Label();
            txtGuncelEmail = new TextBox();
            label17 = new Label();
            label18 = new Label();
            txtGuncelOgrNo = new TextBox();
            btnGuncelle = new Button();
            label15 = new Label();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.LightCoral;
            btnSil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSil.Location = new Point(923, -11);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(204, 196);
            btnSil.TabIndex = 3;
            btnSil.Text = "Seçili öğrenciyi sistemden sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnDelete_Click;
            // 
            // pbFotograf
            // 
            pbFotograf.Location = new Point(-4, 39);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(168, 314);
            pbFotograf.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotograf.TabIndex = 24;
            pbFotograf.TabStop = false;
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AllowUserToAddRows = false;
            dgvOgrenciler.AllowUserToDeleteRows = false;
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciler.BackgroundColor = Color.Red;
            dgvOgrenciler.CausesValidation = false;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Aqua;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvOgrenciler.DefaultCellStyle = dataGridViewCellStyle2;
            dgvOgrenciler.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvOgrenciler.Location = new Point(166, 60);
            dgvOgrenciler.MultiSelect = false;
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.RowHeadersVisible = false;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.Size = new Size(774, 293);
            dgvOgrenciler.TabIndex = 45;
            dgvOgrenciler.CellClick += dgvOgrenciler_CellClick;
            // 
            // btnAktiflikKaydet
            // 
            btnAktiflikKaydet.BackColor = Color.Yellow;
            btnAktiflikKaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAktiflikKaydet.Location = new Point(938, 180);
            btnAktiflikKaydet.Name = "btnAktiflikKaydet";
            btnAktiflikKaydet.Size = new Size(197, 175);
            btnAktiflikKaydet.TabIndex = 46;
            btnAktiflikKaydet.Text = "Seçili öğrencileri Aktif/Pasif Yap";
            btnAktiflikKaydet.UseVisualStyleBackColor = false;
            btnAktiflikKaydet.Click += btnAktiflikKaydet_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label19.Location = new Point(7, 9);
            label19.Name = "label19";
            label19.Size = new Size(160, 15);
            label19.TabIndex = 47;
            label19.Text = "Seçili Öğrencinin Fotoğrafı :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Coral;
            panel1.Controls.Add(btnFotoSil);
            panel1.Controls.Add(btnFotoYukle);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(-4, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 480);
            panel1.TabIndex = 50;
            // 
            // btnFotoSil
            // 
            btnFotoSil.BackColor = Color.CornflowerBlue;
            btnFotoSil.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnFotoSil.Location = new Point(90, 129);
            btnFotoSil.Name = "btnFotoSil";
            btnFotoSil.Size = new Size(73, 265);
            btnFotoSil.TabIndex = 33;
            btnFotoSil.Text = "Fotoğrafı Sil";
            btnFotoSil.UseVisualStyleBackColor = false;
            btnFotoSil.Click += btnFotoSil_Click;
            // 
            // btnFotoYukle
            // 
            btnFotoYukle.BackColor = Color.CornflowerBlue;
            btnFotoYukle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnFotoYukle.Location = new Point(6, 129);
            btnFotoYukle.Name = "btnFotoYukle";
            btnFotoYukle.Size = new Size(78, 265);
            btnFotoYukle.TabIndex = 32;
            btnFotoYukle.Text = "Yükle";
            btnFotoYukle.UseVisualStyleBackColor = false;
            btnFotoYukle.Click += btnFotoYukle_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label10.Location = new Point(52, 84);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 31;
            label10.Text = "Fotoğraf";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtTC);
            panel2.Controls.Add(cmbOkulu);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(cmbSinif);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnEklenenFotoyuSil);
            panel2.Controls.Add(btnFotoEkle);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtTelefon);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(dtpDogumTarihi);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtOgrSoyad);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtOgrAd);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtOgrNo);
            panel2.Controls.Add(btnEkle);
            panel2.Location = new Point(166, 353);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 480);
            panel2.TabIndex = 51;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(84, 67);
            label7.Name = "label7";
            label7.Size = new Size(25, 20);
            label7.TabIndex = 75;
            label7.Text = "TC";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(173, 64);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(113, 23);
            txtTC.TabIndex = 74;
            // 
            // cmbOkulu
            // 
            cmbOkulu.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOkulu.FormattingEnabled = true;
            cmbOkulu.Location = new Point(173, 280);
            cmbOkulu.Name = "cmbOkulu";
            cmbOkulu.Size = new Size(113, 23);
            cmbOkulu.TabIndex = 73;
            cmbOkulu.SelectedIndexChanged += cmbOkulu_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11.25F);
            label12.Location = new Point(73, 283);
            label12.Name = "label12";
            label12.Size = new Size(47, 20);
            label12.TabIndex = 72;
            label12.Text = "Okulu";
            // 
            // cmbSinif
            // 
            cmbSinif.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(173, 315);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(113, 23);
            cmbSinif.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(77, 318);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 70;
            label4.Text = "Sınıf";
            // 
            // btnEklenenFotoyuSil
            // 
            btnEklenenFotoyuSil.BackColor = Color.MediumSlateBlue;
            btnEklenenFotoyuSil.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEklenenFotoyuSil.Location = new Point(289, 0);
            btnEklenenFotoyuSil.Name = "btnEklenenFotoyuSil";
            btnEklenenFotoyuSil.Size = new Size(45, 474);
            btnEklenenFotoyuSil.TabIndex = 34;
            btnEklenenFotoyuSil.Text = "F\r\nO\r\nT\r\nO\r\nĞ\r\nR\r\nA\r\nF\r\nI\r\n\r\nS\r\nİ\r\nL\r\n";
            btnEklenenFotoyuSil.UseVisualStyleBackColor = false;
            btnEklenenFotoyuSil.Click += btnEklenenFotoyuSil_Click;
            // 
            // btnFotoEkle
            // 
            btnFotoEkle.BackColor = Color.MediumSlateBlue;
            btnFotoEkle.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Bold | FontStyle.Italic);
            btnFotoEkle.Location = new Point(0, 0);
            btnFotoEkle.Name = "btnFotoEkle";
            btnFotoEkle.Size = new Size(45, 480);
            btnFotoEkle.TabIndex = 69;
            btnFotoEkle.Text = "Y\r\nÜ\r\nK\r\nL\r\nE\r\n";
            btnFotoEkle.UseVisualStyleBackColor = false;
            btnFotoEkle.Click += btnFotoEkle_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(333, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(343, 477);
            panel3.TabIndex = 0;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label20.Location = new Point(118, 20);
            label20.Name = "label20";
            label20.Size = new Size(106, 21);
            label20.TabIndex = 68;
            label20.Text = "Öğrenci Ekle";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(67, 197);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 64;
            label9.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(173, 197);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(113, 23);
            txtTelefon.TabIndex = 63;
            txtTelefon.Leave += txtTelefon_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(47, 165);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 62;
            label5.Text = "Doğum Tarihi";
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(173, 165);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(113, 23);
            dtpDogumTarihi.TabIndex = 61;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(70, 234);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 58;
            label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(113, 23);
            txtEmail.TabIndex = 57;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(71, 139);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 55;
            label3.Text = "Soyad";
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(173, 136);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(113, 23);
            txtOgrSoyad.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(82, 103);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 53;
            label2.Text = "Ad";
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(173, 103);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(113, 23);
            txtOgrAd.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(54, 359);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 51;
            label1.Text = "Öğrenci No";
            // 
            // txtOgrNo
            // 
            txtOgrNo.Location = new Point(173, 356);
            txtOgrNo.Name = "txtOgrNo";
            txtOgrNo.Size = new Size(113, 23);
            txtOgrNo.TabIndex = 50;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEkle.Location = new Point(67, 398);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(205, 60);
            btnEkle.TabIndex = 49;
            btnEkle.Text = "Öğrenci Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtFilter
            // 
            txtFilter.BackColor = SystemColors.Menu;
            txtFilter.Location = new Point(39, 50);
            txtFilter.Multiline = true;
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(199, 405);
            txtFilter.TabIndex = 27;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label11.Location = new Point(84, 7);
            label11.Name = "label11";
            label11.Size = new Size(127, 21);
            label11.TabIndex = 28;
            label11.Text = "Öğrenci Filtrele";
            // 
            // panel5
            // 
            panel5.BackColor = Color.SpringGreen;
            panel5.Controls.Add(label11);
            panel5.Controls.Add(txtFilter);
            panel5.Location = new Point(839, 353);
            panel5.Name = "panel5";
            panel5.Size = new Size(296, 483);
            panel5.TabIndex = 65;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Cyan;
            panel4.Controls.Add(cmbGuncelSinif);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(cmbGuncelOkul);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(txtGuncelTelefon);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(txtGuncelEmail);
            panel4.Controls.Add(label17);
            panel4.Controls.Add(label18);
            panel4.Controls.Add(txtGuncelOgrNo);
            panel4.Controls.Add(btnGuncelle);
            panel4.Location = new Point(499, 353);
            panel4.Name = "panel4";
            panel4.Size = new Size(344, 477);
            panel4.TabIndex = 66;
            // 
            // cmbGuncelSinif
            // 
            cmbGuncelSinif.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuncelSinif.FormattingEnabled = true;
            cmbGuncelSinif.Location = new Point(186, 336);
            cmbGuncelSinif.Name = "cmbGuncelSinif";
            cmbGuncelSinif.Size = new Size(100, 23);
            cmbGuncelSinif.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(110, 10);
            label8.Name = "label8";
            label8.Size = new Size(141, 21);
            label8.TabIndex = 75;
            label8.Text = "Öğrenci Güncelle";
            // 
            // cmbGuncelOkul
            // 
            cmbGuncelOkul.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGuncelOkul.FormattingEnabled = true;
            cmbGuncelOkul.Location = new Point(186, 266);
            cmbGuncelOkul.Name = "cmbGuncelOkul";
            cmbGuncelOkul.Size = new Size(100, 23);
            cmbGuncelOkul.TabIndex = 74;
            cmbGuncelOkul.SelectedIndexChanged += cmbGuncelOkul_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15.75F);
            label13.Location = new Point(77, 263);
            label13.Name = "label13";
            label13.Size = new Size(68, 30);
            label13.TabIndex = 73;
            label13.Text = "Okulu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F);
            label14.Location = new Point(71, 136);
            label14.Name = "label14";
            label14.Size = new Size(80, 30);
            label14.TabIndex = 71;
            label14.Text = "Telefon";
            // 
            // txtGuncelTelefon
            // 
            txtGuncelTelefon.Location = new Point(186, 143);
            txtGuncelTelefon.Name = "txtGuncelTelefon";
            txtGuncelTelefon.Size = new Size(100, 23);
            txtGuncelTelefon.TabIndex = 70;
            txtGuncelTelefon.Text = "+90";
            txtGuncelTelefon.Leave += txtGuncelTelefon_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label16.Location = new Point(76, 57);
            label16.Name = "label16";
            label16.Size = new Size(71, 30);
            label16.TabIndex = 69;
            label16.Text = "E-mail";
            // 
            // txtGuncelEmail
            // 
            txtGuncelEmail.Location = new Point(186, 60);
            txtGuncelEmail.Name = "txtGuncelEmail";
            txtGuncelEmail.Size = new Size(100, 23);
            txtGuncelEmail.TabIndex = 68;
            txtGuncelEmail.Leave += txtGuncelEmail_Leave;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15.75F);
            label17.Location = new Point(85, 329);
            label17.Name = "label17";
            label17.Size = new Size(53, 30);
            label17.TabIndex = 67;
            label17.Text = "Sınıf";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15.75F);
            label18.Location = new Point(51, 207);
            label18.Name = "label18";
            label18.Size = new Size(120, 30);
            label18.TabIndex = 66;
            label18.Text = "Öğrenci No";
            // 
            // txtGuncelOgrNo
            // 
            txtGuncelOgrNo.Location = new Point(186, 207);
            txtGuncelOgrNo.Name = "txtGuncelOgrNo";
            txtGuncelOgrNo.Size = new Size(100, 23);
            txtGuncelOgrNo.TabIndex = 65;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuncelle.Location = new Point(71, 398);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(210, 60);
            btnGuncelle.TabIndex = 64;
            btnGuncelle.Text = "Öğrenci Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnUpdate_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(333, 10);
            label15.Name = "label15";
            label15.Size = new Size(151, 37);
            label15.TabIndex = 67;
            label15.Text = "Öğrenciler";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Red;
            panel6.Controls.Add(label15);
            panel6.Location = new Point(166, -1);
            panel6.Name = "panel6";
            panel6.Size = new Size(774, 65);
            panel6.TabIndex = 68;
            // 
            // FrmOgrenciIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Coral;
            ClientSize = new Size(1129, 835);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label19);
            Controls.Add(btnAktiflikKaydet);
            Controls.Add(dgvOgrenciler);
            Controls.Add(pbFotograf);
            Controls.Add(btnSil);
            Name = "FrmOgrenciIslemleri";
            Text = "ÖĞRENCİ İŞLEMLERİ";
            Load += FrmOgrenciIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvOgrenciler;
        private Button btnSil;
        private TextBox txtSifreHash;
        private PictureBox pbFotograf;
        private TextBox txtGuncelSifre;
        private Button btnAktiflikKaydet;
        private Label label19;
        private Panel panel1;
        private Button btnFotoSil;
        private Button btnFotoYukle;
        private Label label10;
        private Panel panel2;
        private Label label20;
        private Label label9;
        private TextBox txtTelefon;
        private Label label5;
        private DateTimePicker dtpDogumTarihi;
        private Label label6;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtOgrSoyad;
        private Label label2;
        private TextBox txtOgrAd;
        private Label label1;
        private TextBox txtOgrNo;
        private Button btnEkle;
        private TextBox txtFilter;
        private Label label11;
        private Panel panel5;
        private Panel panel3;
        private Panel panel4;
        private ComboBox cmbGuncelSinif;
        private Label label8;
        private ComboBox cmbGuncelOkul;
        private Label label13;
        private Label label14;
        private TextBox txtGuncelTelefon;
        private Label label16;
        private TextBox txtGuncelEmail;
        private Label label17;
        private Label label18;
        private TextBox txtGuncelOgrNo;
        private Button btnGuncelle;
        private Label label15;
        private Panel panel6;
        private Button btnEklenenFotoyuSil;
        private Button btnFotoEkle;
        private ComboBox cmbOkulu;
        private Label label12;
        private ComboBox cmbSinif;
        private Label label4;
        private Label label7;
        private TextBox txtTC;
    }
}