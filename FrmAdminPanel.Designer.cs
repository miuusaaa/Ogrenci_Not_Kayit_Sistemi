namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class FrmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPanel));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnAdmin = new Button();
            btnDers = new Button();
            btnSinif = new Button();
            btnCikis = new Button();
            btnOgretmen = new Button();
            btnOkul = new Button();
            btnOgrenci = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 53);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(280, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(347, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 32);
            label1.TabIndex = 0;
            label1.Text = "Admin Paneli";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Controls.Add(btnAdmin);
            panel2.Controls.Add(btnDers);
            panel2.Controls.Add(btnSinif);
            panel2.Controls.Add(btnCikis);
            panel2.Controls.Add(btnOgretmen);
            panel2.Controls.Add(btnOkul);
            panel2.Controls.Add(btnOgrenci);
            panel2.Location = new Point(0, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(867, 400);
            panel2.TabIndex = 1;
            // 
            // btnAdmin
            // 
            btnAdmin.Location = new Point(72, 157);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(75, 55);
            btnAdmin.TabIndex = 0;
            btnAdmin.Text = "Admin İşlemleri";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnDers
            // 
            btnDers.Location = new Point(628, 159);
            btnDers.Name = "btnDers";
            btnDers.Size = new Size(75, 57);
            btnDers.TabIndex = 5;
            btnDers.Text = "Ders İşlemleri";
            btnDers.UseVisualStyleBackColor = true;
            btnDers.Click += btnDers_Click;
            // 
            // btnSinif
            // 
            btnSinif.Location = new Point(508, 158);
            btnSinif.Name = "btnSinif";
            btnSinif.Size = new Size(75, 57);
            btnSinif.TabIndex = 4;
            btnSinif.Text = "Sınıf İşlemleri";
            btnSinif.UseVisualStyleBackColor = true;
            btnSinif.Click += btnSinif_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(740, 158);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(75, 54);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnOgretmen
            // 
            btnOgretmen.Location = new Point(282, 160);
            btnOgretmen.Name = "btnOgretmen";
            btnOgretmen.Size = new Size(75, 54);
            btnOgretmen.TabIndex = 2;
            btnOgretmen.Text = "Öğretmen İşlemleri";
            btnOgretmen.UseVisualStyleBackColor = true;
            btnOgretmen.Click += btnOgretmen_Click;
            // 
            // btnOkul
            // 
            btnOkul.Location = new Point(389, 160);
            btnOkul.Name = "btnOkul";
            btnOkul.Size = new Size(75, 57);
            btnOkul.TabIndex = 3;
            btnOkul.Text = "Okul İşlemleri";
            btnOkul.UseVisualStyleBackColor = true;
            btnOkul.Click += btnOkul_Click;
            // 
            // btnOgrenci
            // 
            btnOgrenci.Location = new Point(176, 159);
            btnOgrenci.Name = "btnOgrenci";
            btnOgrenci.Size = new Size(75, 55);
            btnOgrenci.TabIndex = 1;
            btnOgrenci.Text = "Öğrenci İşlemleri";
            btnOgrenci.UseVisualStyleBackColor = true;
            btnOgrenci.Click += btnOgrenci_Click;
            // 
            // FrmAdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 451);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmAdminPanel";
            Text = "FrmAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnCikis;
        private Button btnOgretmen;
        private Button btnOkul;
        private Button btnOgrenci;
        private Button btnDers;
        private Button btnSinif;
        private Button btnAdmin;
    }
}