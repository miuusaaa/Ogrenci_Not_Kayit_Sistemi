namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOgretmen
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
            groupBox1 = new GroupBox();
            btnOgrSil = new Button();
            btnOgrEkle = new Button();
            txtOgrSoyad = new TextBox();
            label3 = new Label();
            txtOgrAd = new TextBox();
            txtOgrOkulNo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnFotoSil = new Button();
            btnFotoYukle = new Button();
            pbFotoYukle = new PictureBox();
            groupBox2 = new GroupBox();
            btnKaydet = new Button();
            txtS3 = new TextBox();
            txtS2 = new TextBox();
            txtS1 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox3 = new GroupBox();
            lblSinifOrt = new Label();
            lblOgrSonuc = new Label();
            lblOgrOrt = new Label();
            label10 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txtNotOkulNo = new TextBox();
            label11 = new Label();
            txtTC = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoYukle).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(btnOgrSil);
            groupBox1.Controls.Add(btnOgrEkle);
            groupBox1.Controls.Add(txtOgrSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtOgrAd);
            groupBox1.Controls.Add(txtOgrOkulNo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnFotoSil);
            groupBox1.Controls.Add(btnFotoYukle);
            groupBox1.Controls.Add(pbFotoYukle);
            groupBox1.Location = new Point(24, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 268);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // btnOgrSil
            // 
            btnOgrSil.Location = new Point(266, 184);
            btnOgrSil.Name = "btnOgrSil";
            btnOgrSil.Size = new Size(75, 68);
            btnOgrSil.TabIndex = 10;
            btnOgrSil.Tag = "";
            btnOgrSil.Text = "Öğrenciyi Sistemden Sil";
            btnOgrSil.UseVisualStyleBackColor = true;
            btnOgrSil.Click += btnOgrSil_Click;
            // 
            // btnOgrEkle
            // 
            btnOgrEkle.Location = new Point(172, 184);
            btnOgrEkle.Name = "btnOgrEkle";
            btnOgrEkle.Size = new Size(75, 68);
            btnOgrEkle.TabIndex = 9;
            btnOgrEkle.Tag = "";
            btnOgrEkle.Text = "Öğrenciyi Sisteme Ekle";
            btnOgrEkle.UseVisualStyleBackColor = true;
            btnOgrEkle.Click += btnOgrEkle_Click;
            // 
            // txtOgrSoyad
            // 
            txtOgrSoyad.Location = new Point(241, 145);
            txtOgrSoyad.Name = "txtOgrSoyad";
            txtOgrSoyad.Size = new Size(100, 23);
            txtOgrSoyad.TabIndex = 8;
            txtOgrSoyad.KeyPress += txtOgrSoyad_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 149);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Soyad :";
            // 
            // txtOgrAd
            // 
            txtOgrAd.Location = new Point(241, 100);
            txtOgrAd.Name = "txtOgrAd";
            txtOgrAd.Size = new Size(100, 23);
            txtOgrAd.TabIndex = 6;
            txtOgrAd.KeyPress += txtOgrAd_KeyPress;
            // 
            // txtOgrOkulNo
            // 
            txtOgrOkulNo.Location = new Point(241, 58);
            txtOgrOkulNo.Name = "txtOgrOkulNo";
            txtOgrOkulNo.Size = new Size(100, 23);
            txtOgrOkulNo.TabIndex = 5;
            txtOgrOkulNo.KeyPress += txtOgrOkulNo_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 103);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "Ad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 66);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Okul No :";
            // 
            // btnFotoSil
            // 
            btnFotoSil.Location = new Point(42, 207);
            btnFotoSil.Name = "btnFotoSil";
            btnFotoSil.Size = new Size(75, 45);
            btnFotoSil.TabIndex = 2;
            btnFotoSil.Text = "Fotoğrafı Kaldır";
            btnFotoSil.UseVisualStyleBackColor = true;
            // 
            // btnFotoYukle
            // 
            btnFotoYukle.Location = new Point(42, 150);
            btnFotoYukle.Name = "btnFotoYukle";
            btnFotoYukle.Size = new Size(75, 49);
            btnFotoYukle.TabIndex = 1;
            btnFotoYukle.Text = "Fotoğraf Yükle";
            btnFotoYukle.UseVisualStyleBackColor = true;
            // 
            // pbFotoYukle
            // 
            pbFotoYukle.Location = new Point(31, 50);
            pbFotoYukle.Name = "pbFotoYukle";
            pbFotoYukle.Size = new Size(100, 83);
            pbFotoYukle.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoYukle.TabIndex = 0;
            pbFotoYukle.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNotOkulNo);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(btnKaydet);
            groupBox2.Controls.Add(txtS3);
            groupBox2.Controls.Add(txtS2);
            groupBox2.Controls.Add(txtS1);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(396, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(305, 268);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Not Ekle";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(94, 229);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(133, 23);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Değişiklikleri Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtS3
            // 
            txtS3.Location = new Point(150, 176);
            txtS3.Name = "txtS3";
            txtS3.Size = new Size(100, 23);
            txtS3.TabIndex = 15;
            txtS3.KeyPress += txtS3_KeyPress;
            // 
            // txtS2
            // 
            txtS2.Location = new Point(150, 129);
            txtS2.Name = "txtS2";
            txtS2.Size = new Size(100, 23);
            txtS2.TabIndex = 14;
            txtS2.KeyPress += txtS2_KeyPress;
            // 
            // txtS1
            // 
            txtS1.Location = new Point(150, 89);
            txtS1.Name = "txtS1";
            txtS1.Size = new Size(100, 23);
            txtS1.TabIndex = 13;
            txtS1.KeyPress += txtS1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 184);
            label7.Name = "label7";
            label7.Size = new Size(50, 15);
            label7.TabIndex = 12;
            label7.Text = "Sınav 3 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 137);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 11;
            label6.Text = "Sınav 2 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 92);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Sınav 1 :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblSinifOrt);
            groupBox3.Controls.Add(lblOgrSonuc);
            groupBox3.Controls.Add(lblOgrOrt);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(715, 30);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(256, 268);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ortalamalar";
            // 
            // lblSinifOrt
            // 
            lblSinifOrt.AutoSize = true;
            lblSinifOrt.Location = new Point(124, 171);
            lblSinifOrt.Name = "lblSinifOrt";
            lblSinifOrt.Size = new Size(0, 15);
            lblSinifOrt.TabIndex = 20;
            // 
            // lblOgrSonuc
            // 
            lblOgrSonuc.AutoSize = true;
            lblOgrSonuc.Location = new Point(124, 129);
            lblOgrSonuc.Name = "lblOgrSonuc";
            lblOgrSonuc.Size = new Size(0, 15);
            lblOgrSonuc.TabIndex = 19;
            // 
            // lblOgrOrt
            // 
            lblOgrOrt.AutoSize = true;
            lblOgrOrt.Location = new Point(157, 83);
            lblOgrOrt.Name = "lblOgrOrt";
            lblOgrOrt.Size = new Size(0, 15);
            lblOgrOrt.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 171);
            label10.Name = "label10";
            label10.Size = new Size(96, 15);
            label10.TabIndex = 17;
            label10.Text = "Sınıf Ortalaması :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 129);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 16;
            label8.Text = "Öğrenci Sonuç : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 83);
            label9.Name = "label9";
            label9.Size = new Size(132, 15);
            label9.TabIndex = 15;
            label9.Text = "Öğrencinin Ortalaması :";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(24, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 274);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(947, 274);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtNotOkulNo
            // 
            txtNotOkulNo.Location = new Point(150, 47);
            txtNotOkulNo.Name = "txtNotOkulNo";
            txtNotOkulNo.Size = new Size(100, 23);
            txtNotOkulNo.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(69, 50);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 17;
            label11.Text = "Okul No :";
            // 
            // txtTC
            // 
            txtTC.Location = new Point(241, 22);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(100, 23);
            txtTC.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(183, 25);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 12;
            label4.Text = "TC No :";
            // 
            // FrmOgretmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 581);
            Controls.Add(panel1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmOgretmen";
            Text = "FrmOgretmen";
            Load += FrmOgretmen_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoYukle).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnFotoSil;
        private Button btnFotoYukle;
        private PictureBox pbFotoYukle;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtOgrAd;
        private TextBox txtOgrOkulNo;
        private Label label2;
        private Label label1;
        private TextBox txtOgrSoyad;
        private TextBox txtS3;
        private TextBox txtS2;
        private TextBox txtS1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnKaydet;
        private Label label8;
        private Label label9;
        private Label lblSinifOrt;
        private Label lblOgrSonuc;
        private Label lblOgrOrt;
        private Label label10;
        private Button btnOgrEkle;
        private Button btnOgrSil;
        private TextBox txtTC;
        private Label label4;
        private TextBox txtNotOkulNo;
        private Label label11;
    }
}