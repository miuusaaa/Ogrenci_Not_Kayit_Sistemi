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
            label1 = new Label();
            panel1 = new Panel();
            dgvOkullar = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            btnOkulSil = new Button();
            txtOkulAd = new TextBox();
            txtGuncelOkulAd = new TextBox();
            label4 = new Label();
            btnOkulEkle = new Button();
            btnOkulGuncelle = new Button();
            label5 = new Label();
            txtboxAra = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOkullar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(366, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Okullar";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 59);
            panel1.TabIndex = 1;
            // 
            // dgvOkullar
            // 
            dgvOkullar.AllowUserToAddRows = false;
            dgvOkullar.AllowUserToDeleteRows = false;
            dgvOkullar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOkullar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvOkullar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOkullar.Location = new Point(-2, 54);
            dgvOkullar.MultiSelect = false;
            dgvOkullar.Name = "dgvOkullar";
            dgvOkullar.ReadOnly = true;
            dgvOkullar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOkullar.Size = new Size(802, 183);
            dgvOkullar.TabIndex = 2;
            dgvOkullar.DataBindingComplete += dgvOkullar_DataBindingComplete;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(99, 258);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 3;
            label2.Text = "Okul Ekle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(327, 258);
            label3.Name = "label3";
            label3.Size = new Size(142, 30);
            label3.TabIndex = 4;
            label3.Text = "Okul Güncelle";
            // 
            // btnOkulSil
            // 
            btnOkulSil.Location = new Point(589, 258);
            btnOkulSil.Name = "btnOkulSil";
            btnOkulSil.Size = new Size(163, 138);
            btnOkulSil.TabIndex = 5;
            btnOkulSil.Text = "Seçilen Okulu Sil";
            btnOkulSil.UseVisualStyleBackColor = true;
            btnOkulSil.Click += btnOkulSil_Click;
            // 
            // txtOkulAd
            // 
            txtOkulAd.Location = new Point(131, 330);
            txtOkulAd.Name = "txtOkulAd";
            txtOkulAd.Size = new Size(100, 23);
            txtOkulAd.TabIndex = 6;
            // 
            // txtGuncelOkulAd
            // 
            txtGuncelOkulAd.Location = new Point(343, 330);
            txtGuncelOkulAd.Name = "txtGuncelOkulAd";
            txtGuncelOkulAd.Size = new Size(100, 23);
            txtGuncelOkulAd.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(32, 323);
            label4.Name = "label4";
            label4.Size = new Size(93, 30);
            label4.TabIndex = 8;
            label4.Text = "Okul Adı";
            // 
            // btnOkulEkle
            // 
            btnOkulEkle.Location = new Point(81, 382);
            btnOkulEkle.Name = "btnOkulEkle";
            btnOkulEkle.Size = new Size(133, 55);
            btnOkulEkle.TabIndex = 9;
            btnOkulEkle.Text = "Okulu Ekle";
            btnOkulEkle.UseVisualStyleBackColor = true;
            btnOkulEkle.Click += btnOkulEkle_Click;
            // 
            // btnOkulGuncelle
            // 
            btnOkulGuncelle.Location = new Point(315, 382);
            btnOkulGuncelle.Name = "btnOkulGuncelle";
            btnOkulGuncelle.Size = new Size(163, 54);
            btnOkulGuncelle.TabIndex = 10;
            btnOkulGuncelle.Text = "Okulu Adını Güncelle";
            btnOkulGuncelle.UseVisualStyleBackColor = true;
            btnOkulGuncelle.Click += btnOkulGuncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(506, 411);
            label5.Name = "label5";
            label5.Size = new Size(140, 30);
            label5.TabIndex = 12;
            label5.Text = "İsme göre ara";
            // 
            // txtboxAra
            // 
            txtboxAra.Location = new Point(652, 413);
            txtboxAra.Name = "txtboxAra";
            txtboxAra.Size = new Size(100, 23);
            txtboxAra.TabIndex = 11;
            txtboxAra.TextChanged += txtboxAra_TextChanged;
            // 
            // FrmOkulIslemleri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(txtboxAra);
            Controls.Add(btnOkulGuncelle);
            Controls.Add(btnOkulEkle);
            Controls.Add(label4);
            Controls.Add(txtGuncelOkulAd);
            Controls.Add(txtOkulAd);
            Controls.Add(btnOkulSil);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvOkullar);
            Controls.Add(panel1);
            Name = "FrmOkulIslemleri";
            Text = "FrmOkulIslemleri";
            Load += FrmOkulIslemleri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOkullar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dgvOkullar;
        private Label label2;
        private Label label3;
        private Button btnOkulSil;
        private TextBox txtOkulAd;
        private TextBox txtGuncelOkulAd;
        private Label label4;
        private Button btnOkulEkle;
        private Button btnOkulGuncelle;
        private Label label5;
        private TextBox txtboxAra;
    }
}