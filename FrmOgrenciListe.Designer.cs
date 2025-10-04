namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgrenciListe
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
            dgvOgrenciler = new DataGridView();
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
            label8 = new Label();
            txtSifreHash = new TextBox();
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
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            SuspendLayout();
            // 
            // dgvOgrenciler
            // 
            dgvOgrenciler.AllowUserToAddRows = false;
            dgvOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgrenciler.CausesValidation = false;
            dgvOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgrenciler.Dock = DockStyle.Top;
            dgvOgrenciler.Location = new Point(0, 0);
            dgvOgrenciler.MultiSelect = false;
            dgvOgrenciler.Name = "dgvOgrenciler";
            dgvOgrenciler.ReadOnly = true;
            dgvOgrenciler.RowHeadersVisible = false;
            dgvOgrenciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOgrenciler.Size = new Size(857, 356);
            dgvOgrenciler.TabIndex = 0;
            dgvOgrenciler.CellClick += dgvOgrenciler_CellClick;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(318, 495);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 43);
            btnEkle.TabIndex = 1;
            btnEkle.Text = "Öğrenci Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(409, 495);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(75, 43);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "Öğrenci Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnUpdate_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(502, 495);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 43);
            btnSil.TabIndex = 3;
            btnSil.Text = "Öğrenci Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnDelete_Click;
            // 
            // txtOgrNo
            // 
            txtOgrNo.Location = new Point(128, 386);
            txtOgrNo.Name = "txtOgrNo";
            txtOgrNo.Size = new Size(100, 23);
            txtOgrNo.TabIndex = 4;
            txtOgrNo.KeyPress += txtOgrNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 368);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 7;
            label2.Text = "Ad";
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(234, 386);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(100, 23);
            txtOgrAd.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 368);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Soyad";
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(341, 386);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(100, 23);
            txtOgrSoyad.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(739, 362);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "Sınıf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 418);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 15;
            label6.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(511, 447);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(601, 368);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 17;
            label7.Text = "TC";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(572, 386);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 16;
            txtTC.KeyPress += txtTC_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(671, 429);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 19;
            label8.Text = "Şifre";
            // 
            // txtSifreHash
            // 
            txtSifreHash.Location = new Point(643, 447);
            txtSifreHash.Name = "txtSifreHash";
            txtSifreHash.Size = new Size(100, 23);
            txtSifreHash.TabIndex = 18;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(457, 386);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(79, 23);
            dtpDogumTarihi.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 368);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci No";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(457, 365);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 21;
            label5.Text = "Doğum Tarihi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 418);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 23;
            label9.Text = "Telefon";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(373, 447);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(100, 23);
            txtTelefon.TabIndex = 22;
            txtTelefon.Text = "+90";
            txtTelefon.KeyPress += txtTelefon_KeyPress;
            // 
            // pbFotograf
            // 
            pbFotograf.Location = new Point(176, 437);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(100, 50);
            pbFotograf.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotograf.TabIndex = 24;
            pbFotograf.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(297, 455);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 25;
            label10.Text = "Fotoğraf";
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(694, 386);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(121, 23);
            cmbSinif.TabIndex = 26;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(112, 515);
            txtFilter.Name = "txtFilter";
            txtFilter.Size = new Size(100, 23);
            txtFilter.TabIndex = 27;
            txtFilter.TextChanged += txtFilter_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(50, 518);
            label11.Name = "label11";
            label11.Size = new Size(25, 15);
            label11.TabIndex = 28;
            label11.Text = "Ara";
            // 
            // btnFotoSil
            // 
            btnFotoSil.Location = new Point(21, 442);
            btnFotoSil.Name = "btnFotoSil";
            btnFotoSil.Size = new Size(68, 41);
            btnFotoSil.TabIndex = 30;
            btnFotoSil.Text = "Fotoğrafı Sil";
            btnFotoSil.UseVisualStyleBackColor = true;
            btnFotoSil.Click += btnFotoSil_Click;
            // 
            // btnFotoYukle
            // 
            btnFotoYukle.Location = new Point(105, 437);
            btnFotoYukle.Name = "btnFotoYukle";
            btnFotoYukle.Size = new Size(53, 50);
            btnFotoYukle.TabIndex = 29;
            btnFotoYukle.Text = "Yükle";
            btnFotoYukle.UseVisualStyleBackColor = true;
            btnFotoYukle.Click += btnFotoYukle_Click;
            // 
            // FrmOgrenciListe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(857, 561);
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
            Controls.Add(label8);
            Controls.Add(txtSifreHash);
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
            Controls.Add(dgvOgrenciler);
            Name = "FrmOgrenciListe";
            Text = "Ara";
            Load += FrmOgrenciListe_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOgrenciler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
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
    }
}