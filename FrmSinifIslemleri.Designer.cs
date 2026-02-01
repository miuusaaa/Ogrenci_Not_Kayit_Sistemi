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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSinifIslemleri));
            label2 = new Label();
            txtOkulAra = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label5 = new Label();
            cmbOkullar = new ComboBox();
            panel4 = new Panel();
            label1 = new Label();
            clbSiniflar = new CheckedListBox();
            btnSinifSil = new Button();
            panel5 = new Panel();
            label4 = new Label();
            txtYeniSinifAd = new TextBox();
            btnSinifEkle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(250, 15);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 18;
            label2.Text = "Okula göre ara";
            // 
            // txtOkulAra
            // 
            txtOkulAra.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtOkulAra.Location = new Point(386, 15);
            txtOkulAra.Name = "txtOkulAra";
            txtOkulAra.Size = new Size(258, 26);
            txtOkulAra.TabIndex = 17;
            txtOkulAra.TextChanged += txtOkulAra_TextChanged;
            txtOkulAra.KeyUp += txtOkulAra_KeyUp;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(txtOkulAra);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 62);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.Location = new Point(4, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(796, 98);
            panel2.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(185, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(128, 255, 255);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(cmbOkullar);
            panel3.Location = new Point(-1, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(802, 95);
            panel3.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.Location = new Point(250, 33);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 37;
            label5.Text = "Okul Seçin";
            // 
            // cmbOkullar
            // 
            cmbOkullar.FormattingEnabled = true;
            cmbOkullar.Location = new Point(386, 33);
            cmbOkullar.Name = "cmbOkullar";
            cmbOkullar.Size = new Size(258, 23);
            cmbOkullar.TabIndex = 36;
            cmbOkullar.SelectedIndexChanged += cmbOkullar_SelectedIndexChanged;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 192, 192);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(clbSiniflar);
            panel4.Controls.Add(btnSinifSil);
            panel4.Location = new Point(0, 151);
            panel4.Name = "panel4";
            panel4.Size = new Size(398, 300);
            panel4.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(28, 62);
            label1.Name = "label1";
            label1.Size = new Size(207, 20);
            label1.TabIndex = 35;
            label1.Text = "Seçilen Okula Ait Sınıflar";
            // 
            // clbSiniflar
            // 
            clbSiniflar.BackColor = Color.FromArgb(192, 255, 192);
            clbSiniflar.FormattingEnabled = true;
            clbSiniflar.Location = new Point(249, 20);
            clbSiniflar.Name = "clbSiniflar";
            clbSiniflar.Size = new Size(125, 130);
            clbSiniflar.TabIndex = 34;
            // 
            // btnSinifSil
            // 
            btnSinifSil.BackColor = Color.Lime;
            btnSinifSil.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSinifSil.Location = new Point(28, 161);
            btnSinifSil.Name = "btnSinifSil";
            btnSinifSil.Size = new Size(346, 101);
            btnSinifSil.TabIndex = 33;
            btnSinifSil.Text = "Seçilen Sınıfları İlgili Okuldan Kaldır";
            btnSinifSil.UseVisualStyleBackColor = false;
            btnSinifSil.Click += btnSinifSil_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Teal;
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtYeniSinifAd);
            panel5.Controls.Add(btnSinifEkle);
            panel5.Location = new Point(396, 151);
            panel5.Name = "panel5";
            panel5.Size = new Size(407, 298);
            panel5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.Location = new Point(47, 68);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 31;
            label4.Text = "Yeni Sınıf Adı";
            // 
            // txtYeniSinifAd
            // 
            txtYeniSinifAd.BackColor = Color.FromArgb(192, 192, 255);
            txtYeniSinifAd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            txtYeniSinifAd.Location = new Point(208, 62);
            txtYeniSinifAd.Name = "txtYeniSinifAd";
            txtYeniSinifAd.Size = new Size(174, 26);
            txtYeniSinifAd.TabIndex = 30;
            // 
            // btnSinifEkle
            // 
            btnSinifEkle.BackColor = Color.Blue;
            btnSinifEkle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnSinifEkle.Location = new Point(34, 161);
            btnSinifEkle.Name = "btnSinifEkle";
            btnSinifEkle.Size = new Size(348, 101);
            btnSinifEkle.TabIndex = 32;
            btnSinifEkle.Text = "Sınıfı İlgili Okula Ekle";
            btnSinifEkle.UseVisualStyleBackColor = false;
            btnSinifEkle.Click += btnSinifEkle_Click;
            // 
            // FrmSinifIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "FrmSinifIslemleri";
            Text = "FrmSinifIslemleri";
            Load += FrmSinifIslemleri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private TextBox txtOkulAra;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        protected internal Label label5;
        private ComboBox cmbOkullar;
        protected internal Label label1;
        private CheckedListBox clbSiniflar;
        private Button btnSinifSil;
        private Label label4;
        private TextBox txtYeniSinifAd;
        private Button btnSinifEkle;
    }
}