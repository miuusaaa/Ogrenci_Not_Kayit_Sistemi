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
            lblOgretmen = new Label();
            txtOgrenciAra = new TextBox();
            label2 = new Label();
            dgvNotlar = new DataGridView();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNotlar).BeginInit();
            SuspendLayout();
            // 
            // lblOgretmen
            // 
            lblOgretmen.AutoSize = true;
            lblOgretmen.Font = new Font("Trebuchet MS", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblOgretmen.Location = new Point(406, 9);
            lblOgretmen.Name = "lblOgretmen";
            lblOgretmen.Size = new Size(0, 43);
            lblOgretmen.TabIndex = 0;
            // 
            // txtOgrenciAra
            // 
            txtOgrenciAra.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOgrenciAra.Location = new Point(579, 60);
            txtOgrenciAra.Name = "txtOgrenciAra";
            txtOgrenciAra.Size = new Size(224, 35);
            txtOgrenciAra.TabIndex = 1;
            txtOgrenciAra.TextChanged += txtOgrenciAra_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 70);
            label2.Name = "label2";
            label2.Size = new Size(318, 15);
            label2.TabIndex = 3;
            label2.Text = "Öğrenci TC ,Sınıf ,Öğrenci ad-soyad veya nota göre filtrele :";
            // 
            // dgvNotlar
            // 
            dgvNotlar.AllowUserToAddRows = false;
            dgvNotlar.AllowUserToDeleteRows = false;
            dgvNotlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotlar.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvNotlar.Location = new Point(0, 101);
            dgvNotlar.Name = "dgvNotlar";
            dgvNotlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotlar.Size = new Size(1001, 272);
            dgvNotlar.TabIndex = 4;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(406, 416);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(212, 131);
            btnKaydet.TabIndex = 5;
            btnKaydet.Text = "Notları Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmOgretmen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 581);
            Controls.Add(btnKaydet);
            Controls.Add(dgvNotlar);
            Controls.Add(label2);
            Controls.Add(txtOgrenciAra);
            Controls.Add(lblOgretmen);
            Name = "FrmOgretmen";
            Text = "FrmOgretmen";
            ((System.ComponentModel.ISupportInitialize)dgvNotlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOgretmen;
        private TextBox txtOgrenciAra;
        private Label label2;
        private DataGridView dgvNotlar;
        private Button btnKaydet;
    }
}