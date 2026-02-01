namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmOkulIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOkulIslemleri));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            txtboxAra = new TextBox();
            dgvOkullar = new DataGridView();
            btnOkulSil = new Button();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            btnOkulEkle = new Button();
            label4 = new Label();
            txtOkulAd = new TextBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            label3 = new Label();
            label1 = new Label();
            btnOkulGuncelle = new Button();
            txtGuncelOkulAd = new TextBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOkullar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtboxAra);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 57);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(124, 10);
            label5.Name = "label5";
            label5.Size = new Size(146, 30);
            label5.TabIndex = 14;
            label5.Text = "İsme göre ara";
            // 
            // txtboxAra
            // 
            txtboxAra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtboxAra.Location = new Point(279, 10);
            txtboxAra.Name = "txtboxAra";
            txtboxAra.Size = new Size(503, 35);
            txtboxAra.TabIndex = 13;
            txtboxAra.TextChanged += txtboxAra_TextChanged;
            // 
            // dgvOkullar
            // 
            dgvOkullar.AllowUserToAddRows = false;
            dgvOkullar.AllowUserToDeleteRows = false;
            dgvOkullar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOkullar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvOkullar.BackgroundColor = Color.DarkMagenta;
            dgvOkullar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOkullar.Location = new Point(-9, 56);
            dgvOkullar.MultiSelect = false;
            dgvOkullar.Name = "dgvOkullar";
            dgvOkullar.ReadOnly = true;
            dgvOkullar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOkullar.Size = new Size(658, 183);
            dgvOkullar.TabIndex = 2;
            dgvOkullar.DataBindingComplete += dgvOkullar_DataBindingComplete;
            // 
            // btnOkulSil
            // 
            btnOkulSil.BackColor = Color.Coral;
            btnOkulSil.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOkulSil.Location = new Point(645, 130);
            btnOkulSil.Name = "btnOkulSil";
            btnOkulSil.Size = new Size(155, 115);
            btnOkulSil.TabIndex = 5;
            btnOkulSil.Text = "Seçilen Okulu Sil";
            btnOkulSil.UseVisualStyleBackColor = false;
            btnOkulSil.Click += btnOkulSil_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 192);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnOkulEkle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtOkulAd);
            panel2.Location = new Point(0, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 209);
            panel2.TabIndex = 11;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.GreenYellow;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(121, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.GreenYellow;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(122, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 61);
            panel3.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(93, 17);
            label2.Name = "label2";
            label2.Size = new Size(106, 30);
            label2.TabIndex = 11;
            label2.Text = "Okul Ekle";
            // 
            // btnOkulEkle
            // 
            btnOkulEkle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOkulEkle.Location = new Point(28, 139);
            btnOkulEkle.Name = "btnOkulEkle";
            btnOkulEkle.Size = new Size(360, 55);
            btnOkulEkle.TabIndex = 13;
            btnOkulEkle.Text = "Okulu Ekle";
            btnOkulEkle.UseVisualStyleBackColor = true;
            btnOkulEkle.Click += btnOkulEkle_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(28, 85);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 12;
            label4.Text = "Okul Adı";
            // 
            // txtOkulAd
            // 
            txtOkulAd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtOkulAd.Location = new Point(134, 82);
            txtOkulAd.Name = "txtOkulAd";
            txtOkulAd.Size = new Size(254, 35);
            txtOkulAd.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 192, 255);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(btnOkulGuncelle);
            panel4.Controls.Add(txtGuncelOkulAd);
            panel4.Location = new Point(410, 239);
            panel4.Name = "panel4";
            panel4.Size = new Size(392, 214);
            panel4.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(128, 128, 255);
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(115, 63);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(128, 128, 255);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(111, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(282, 63);
            panel5.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(80, 16);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 5;
            label3.Text = "Okul Güncelle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(84, 30);
            label1.TabIndex = 18;
            label1.Text = "Yeni ad";
            // 
            // btnOkulGuncelle
            // 
            btnOkulGuncelle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            btnOkulGuncelle.Location = new Point(29, 139);
            btnOkulGuncelle.Name = "btnOkulGuncelle";
            btnOkulGuncelle.Size = new Size(341, 54);
            btnOkulGuncelle.TabIndex = 17;
            btnOkulGuncelle.Text = "Okulu Adını Güncelle";
            btnOkulGuncelle.UseVisualStyleBackColor = true;
            btnOkulGuncelle.Click += btnOkulGuncelle_Click;
            // 
            // txtGuncelOkulAd
            // 
            txtGuncelOkulAd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            txtGuncelOkulAd.Location = new Point(111, 85);
            txtGuncelOkulAd.Name = "txtGuncelOkulAd";
            txtGuncelOkulAd.Size = new Size(259, 35);
            txtGuncelOkulAd.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Coral;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(645, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(155, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // FrmOkulIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(btnOkulSil);
            Controls.Add(dgvOkullar);
            Controls.Add(panel1);
            Name = "FrmOkulIslemleri";
            Text = "FrmOkulIslemleri";
            Load += FrmOkulIslemleri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOkullar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DataGridView dgvOkullar;
        private Button btnOkulSil;
        private Label label5;
        private TextBox txtboxAra;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button btnOkulEkle;
        private Label label4;
        private TextBox txtOkulAd;
        private Panel panel4;
        private Panel panel5;
        private Label label3;
        private Label label1;
        private Button btnOkulGuncelle;
        private TextBox txtGuncelOkulAd;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
    }
}