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
            btnOgrGiris.Location = new Point(333, 52);
            btnOgrGiris.Name = "btnOgrGiris";
            btnOgrGiris.Size = new Size(138, 70);
            btnOgrGiris.TabIndex = 0;
            btnOgrGiris.Text = "Öğrenci Giriş";
            btnOgrGiris.UseVisualStyleBackColor = true;
            btnOgrGiris.Click += btnOgrGiris_Click;
            // 
            // btnOgmGiris
            // 
            btnOgmGiris.Location = new Point(333, 172);
            btnOgmGiris.Name = "btnOgmGiris";
            btnOgmGiris.Size = new Size(138, 79);
            btnOgmGiris.TabIndex = 1;
            btnOgmGiris.Text = "Öğretmen Giriş";
            btnOgmGiris.UseVisualStyleBackColor = true;
            btnOgmGiris.Click += btnOgmGiris_Click;
            // 
            // btnAdminGiris
            // 
            btnAdminGiris.Location = new Point(333, 310);
            btnAdminGiris.Name = "btnAdminGiris";
            btnAdminGiris.Size = new Size(138, 79);
            btnAdminGiris.TabIndex = 2;
            btnAdminGiris.Text = "Admin Giriş";
            btnAdminGiris.UseVisualStyleBackColor = true;
            btnAdminGiris.Click += btnAdminGiris_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminGiris);
            Controls.Add(btnOgmGiris);
            Controls.Add(btnOgrGiris);
            Name = "Anasayfa";
            Text = "Hoşgeldiniz";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOgrGiris;
        private Button btnOgmGiris;
        private Button btnAdminGiris;
    }
}
