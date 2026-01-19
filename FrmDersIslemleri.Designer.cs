namespace Öğrenci_Not_Kayıt_Sistemi
{

    partial class FrmDersIslemleri
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDersAdi = new TextBox();
            cmbDers = new ComboBox();
            cmbSinif = new ComboBox();
            cmbOkul = new ComboBox();
            txtAra = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(568, 282);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(75, 23);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "Dersi Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(660, 281);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(98, 23);
            btnGuncelle.TabIndex = 1;
            btnGuncelle.Text = "Dersi Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(568, 215);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(190, 23);
            btnSil.TabIndex = 6;
            btnSil.Text = "Dersi Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 82);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 3;
            label1.Text = "Okullar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 290);
            label2.Name = "label2";
            label2.Size = new Size(144, 15);
            label2.TabIndex = 4;
            label2.Text = "Ders adı girin (opsiyonel) :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 153);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 4;
            label3.Text = "Sınıflar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 218);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 5;
            label4.Text = "Dersler";
            // 
            // txtDersAdi
            // 
            txtDersAdi.Location = new Point(376, 282);
            txtDersAdi.Name = "txtDersAdi";
            txtDersAdi.Size = new Size(137, 23);
            txtDersAdi.TabIndex = 3;
            // 
            // cmbDers
            // 
            cmbDers.FormattingEnabled = true;
            cmbDers.Location = new Point(376, 215);
            cmbDers.Name = "cmbDers";
            cmbDers.Size = new Size(137, 23);
            cmbDers.TabIndex = 2;
            cmbDers.SelectedIndexChanged += cmbDers_SelectedIndexChanged;
            // 
            // cmbSinif
            // 
            cmbSinif.FormattingEnabled = true;
            cmbSinif.Location = new Point(376, 153);
            cmbSinif.Name = "cmbSinif";
            cmbSinif.Size = new Size(137, 23);
            cmbSinif.TabIndex = 1;
            cmbSinif.SelectedIndexChanged += cmbSinif_SelectedIndexChanged;
            // 
            // cmbOkul
            // 
            cmbOkul.FormattingEnabled = true;
            cmbOkul.Location = new Point(376, 74);
            cmbOkul.Name = "cmbOkul";
            cmbOkul.Size = new Size(137, 23);
            cmbOkul.TabIndex = 0;
            cmbOkul.SelectedIndexChanged += cmbOkul_SelectedIndexChanged;
            // 
            // txtAra
            // 
            txtAra.Location = new Point(376, 385);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(293, 23);
            txtAra.TabIndex = 4;
            txtAra.TextChanged += txtAra_TextChanged;
            txtAra.KeyUp += txtAra_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 388);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 10;
            label5.Text = "Okula göre ara";
            // 
            // FrmDersIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAra);
            Controls.Add(label5);
            Controls.Add(cmbOkul);
            Controls.Add(cmbSinif);
            Controls.Add(cmbDers);
            Controls.Add(txtDersAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Name = "FrmDersIslemleri";
            Text = "FrmDersIslemleri";
            Load += FrmDersIslemleri_Load;
            Shown += FrmDersIslemleri_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDersAdi;
        private ComboBox cmbDers;
        private ComboBox cmbSinif;
        private ComboBox cmbOkul;
        private TextBox txtAra;
        private Label label5;
    }
}