namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmSinifIslemleri
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
            txtYeniSinifAd = new TextBox();
            label4 = new Label();
            cmbOkullar = new ComboBox();
            label5 = new Label();
            btnSinifEkle = new Button();
            btnSinifSil = new Button();
            clbSiniflar = new CheckedListBox();
            label1 = new Label();
            label2 = new Label();
            txtOkulAra = new TextBox();
            SuspendLayout();
            // 
            // txtYeniSinifAd
            // 
            txtYeniSinifAd.Location = new Point(361, 306);
            txtYeniSinifAd.Name = "txtYeniSinifAd";
            txtYeniSinifAd.Size = new Size(258, 23);
            txtYeniSinifAd.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(229, 306);
            label4.Name = "label4";
            label4.Size = new Size(101, 21);
            label4.TabIndex = 5;
            label4.Text = "Yeni Sınıf Adı";
            // 
            // cmbOkullar
            // 
            cmbOkullar.FormattingEnabled = true;
            cmbOkullar.Location = new Point(361, 44);
            cmbOkullar.Name = "cmbOkullar";
            cmbOkullar.Size = new Size(258, 23);
            cmbOkullar.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(246, 46);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 7;
            label5.Text = "Okul Seçin";
            // 
            // btnSinifEkle
            // 
            btnSinifEkle.Location = new Point(635, 293);
            btnSinifEkle.Name = "btnSinifEkle";
            btnSinifEkle.Size = new Size(98, 46);
            btnSinifEkle.TabIndex = 8;
            btnSinifEkle.Text = "Sınıfı İlgili Okula Ekle";
            btnSinifEkle.UseVisualStyleBackColor = true;
            btnSinifEkle.Click += btnSinifEkle_Click;
            // 
            // btnSinifSil
            // 
            btnSinifSil.Location = new Point(635, 142);
            btnSinifSil.Name = "btnSinifSil";
            btnSinifSil.Size = new Size(98, 58);
            btnSinifSil.TabIndex = 14;
            btnSinifSil.Text = "Seçilen Sınıfları İlgili Okuldan Kaldır";
            btnSinifSil.UseVisualStyleBackColor = true;
            btnSinifSil.Click += btnSinifSil_Click;
            // 
            // clbSiniflar
            // 
            clbSiniflar.FormattingEnabled = true;
            clbSiniflar.Location = new Point(361, 110);
            clbSiniflar.Name = "clbSiniflar";
            clbSiniflar.Size = new Size(258, 112);
            clbSiniflar.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(155, 110);
            label1.Name = "label1";
            label1.Size = new Size(180, 21);
            label1.TabIndex = 16;
            label1.Text = "Seçilen Okula Ait Sınıflar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(225, 395);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 18;
            label2.Text = "Okula göre ara";
            // 
            // txtOkulAra
            // 
            txtOkulAra.Location = new Point(361, 395);
            txtOkulAra.Name = "txtOkulAra";
            txtOkulAra.Size = new Size(258, 23);
            txtOkulAra.TabIndex = 17;
            txtOkulAra.TextChanged += txtOkulAra_TextChanged;
            txtOkulAra.KeyUp += txtOkulAra_KeyUp;
            // 
            // FrmSinifIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtOkulAra);
            Controls.Add(label1);
            Controls.Add(clbSiniflar);
            Controls.Add(btnSinifSil);
            Controls.Add(btnSinifEkle);
            Controls.Add(label5);
            Controls.Add(cmbOkullar);
            Controls.Add(label4);
            Controls.Add(txtYeniSinifAd);
            Name = "FrmSinifIslemleri";
            Text = "FrmSinifIslemleri";
            Load += FrmSinifIslemleri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtYeniSinifAd;
        private Label label4;
        private ComboBox cmbOkullar;
        private Button btnSinifEkle;
        private Button btnSinifSil;
        protected internal Label label5;
        private CheckedListBox clbSiniflar;
        protected internal Label label1;
        private Label label2;
        private TextBox txtOkulAra;
    }
}