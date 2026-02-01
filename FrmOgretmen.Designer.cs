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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgretmen));
            dgvNotlar = new DataGridView();
            btnNotlariKaydet = new Button();
            lblOgretmen = new Label();
            txtAra = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cmbDurum = new ComboBox();
            panel1 = new Panel();
            label3 = new Label();
            pbResim = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvNotlar).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvNotlar
            // 
            dgvNotlar.AllowUserToAddRows = false;
            dgvNotlar.AllowUserToDeleteRows = false;
            dgvNotlar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvNotlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotlar.BackgroundColor = Color.Ivory;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 255, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNotlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNotlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotlar.Cursor = Cursors.Hand;
            dgvNotlar.GridColor = Color.FromArgb(255, 192, 255);
            dgvNotlar.Location = new Point(164, 182);
            dgvNotlar.MultiSelect = false;
            dgvNotlar.Name = "dgvNotlar";
            dgvNotlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotlar.Size = new Size(835, 370);
            dgvNotlar.TabIndex = 0;
            dgvNotlar.CellFormatting += dgvNotlar_CellFormatting;
            dgvNotlar.CellValidating += dgvNotlar_CellValidating;
            dgvNotlar.SelectionChanged += dgvNotlar_SelectionChanged;
            // 
            // btnNotlariKaydet
            // 
            btnNotlariKaydet.BackColor = Color.FromArgb(255, 192, 255);
            btnNotlariKaydet.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnNotlariKaydet.ForeColor = Color.CornflowerBlue;
            btnNotlariKaydet.Location = new Point(445, 574);
            btnNotlariKaydet.Name = "btnNotlariKaydet";
            btnNotlariKaydet.Size = new Size(245, 60);
            btnNotlariKaydet.TabIndex = 1;
            btnNotlariKaydet.Text = "Notları Kaydet";
            btnNotlariKaydet.UseVisualStyleBackColor = false;
            btnNotlariKaydet.Click += btnNotlariKaydet_Click;
            // 
            // lblOgretmen
            // 
            lblOgretmen.AutoSize = true;
            lblOgretmen.BackColor = Color.FromArgb(255, 192, 255);
            lblOgretmen.Font = new Font("Algerian", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOgretmen.Location = new Point(311, 28);
            lblOgretmen.Name = "lblOgretmen";
            lblOgretmen.Size = new Size(0, 35);
            lblOgretmen.TabIndex = 3;
            // 
            // txtAra
            // 
            txtAra.BackColor = Color.FromArgb(255, 192, 255);
            txtAra.Location = new Point(678, 139);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(179, 23);
            txtAra.TabIndex = 4;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(36, 137);
            label1.Name = "label1";
            label1.Size = new Size(636, 25);
            label1.TabIndex = 5;
            label1.Text = "Öğrenci ad,soyad,TC,sınıfı,sınav notu veya ortalamasına göre filtrele :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(393, 96);
            label2.Name = "label2";
            label2.Size = new Size(266, 25);
            label2.TabIndex = 6;
            label2.Text = "Sadece şu öğrencileri listele :";
            // 
            // cmbDurum
            // 
            cmbDurum.BackColor = Color.FromArgb(255, 192, 255);
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(678, 96);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(179, 23);
            cmbDurum.TabIndex = 7;
            cmbDurum.SelectedIndexChanged += cmbDurum_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pbResim);
            panel1.Location = new Point(-1, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 370);
            panel1.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(2, 21);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 1;
            label3.Text = "Seçili Öğrencinin Fotoğrafı :";
            // 
            // pbResim
            // 
            pbResim.BackColor = Color.FromArgb(255, 192, 255);
            pbResim.Location = new Point(0, 56);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(165, 314);
            pbResim.SizeMode = PictureBoxSizeMode.Zoom;
            pbResim.TabIndex = 0;
            pbResim.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 574);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FrmOgretmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(1001, 675);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(cmbDurum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAra);
            Controls.Add(lblOgretmen);
            Controls.Add(btnNotlariKaydet);
            Controls.Add(dgvNotlar);
            Name = "FrmOgretmen";
            Text = "FrmOgretmen";
            Load += FrmOgretmen_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNotlar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNotlar;
        private Button btnNotlariKaydet;
        private Label lblOgretmen;
        private TextBox txtAra;
        private Label label1;
        private Label label2;
        private ComboBox cmbDurum;
        private Panel panel1;
        private PictureBox pbResim;
        private Label label3;
        private PictureBox pictureBox1;
    }
}