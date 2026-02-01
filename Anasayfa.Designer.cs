namespace Öğrenci_Not_Kayıt_Sistemi
{
    partial class Anasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOgrGiris = new Button();
            btnOgmGiris = new Button();
            btnAdminGiris = new Button();
            SuspendLayout();
            // 
            // btnOgrGiris
            // 
            btnOgrGiris.BackColor = Color.MidnightBlue;
            btnOgrGiris.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOgrGiris.Location = new Point(365, 35);
            btnOgrGiris.Name = "btnOgrGiris";
            btnOgrGiris.Size = new Size(199, 153);
            btnOgrGiris.TabIndex = 0;
            btnOgrGiris.Text = "Öğrenci Giriş";
            btnOgrGiris.UseVisualStyleBackColor = false;
            btnOgrGiris.Click += btnOgrGiris_Click;
            // 
            // btnOgmGiris
            // 
            btnOgmGiris.BackColor = Color.DarkGreen;
            btnOgmGiris.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            btnOgmGiris.Location = new Point(241, 206);
            btnOgmGiris.Name = "btnOgmGiris";
            btnOgmGiris.Size = new Size(458, 90);
            btnOgmGiris.TabIndex = 1;
            btnOgmGiris.Text = "Öğretmen Giriş";
            btnOgmGiris.UseVisualStyleBackColor = false;
            btnOgmGiris.Click += btnOgmGiris_Click;
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.BackColor = Color.Indigo;
            btnAdminGiris.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            btnAdminGiris.Location = new Point(365, 315);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(199, 147);
            btnAdminGiris.TabIndex = 2;
            btnAdminGiris.Text = "Admin Giriş";
            btnAdminGiris.UseVisualStyleBackColor = false;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            ClientSize = new Size(914, 510);
            Controls.Add(btnAdminGiris);
            Controls.Add(btnOgmGiris);
            Controls.Add(btnOgrGiris);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Red;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Anasayfa";
            Text = "Not Bilgilendirme Sistemine Hoşgeldiniz !!!";
            Load += Anasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOgrGiris;
        private Button btnOgmGiris;
        private Button btnAdminGiris;
    }
}
