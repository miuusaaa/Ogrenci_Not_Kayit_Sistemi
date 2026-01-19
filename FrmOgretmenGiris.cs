using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgretmenGiris : Form
    {
        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }

        string con = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private bool girisTamamlandi = false;

        private void FrmOgretmenGiris_Load(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.TabStop = true;
                else
                    c.TabStop = false;
            }

            // Başlangıçta doğrulama elemanları gizli
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            btnDevam.Visible = false;
            lblTalimat.Visible = false;

            this.Width = 816;
            this.Height = 489;

            mskSifre.PasswordChar = '*';
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text;
            string sifre = mskSifre.Text;

            if (string.IsNullOrWhiteSpace(kullanici) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun !");
                return;
            }

            using (SqlConnection conn = new SqlConnection(con))
            {
                conn.Open();
                string query = @"SELECT Aktif, SifreHash 
                 FROM OGRETMEN_GIRIS 
                 WHERE KullaniciAdi = @kullanici";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kullanici", kullanici);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        // Kullanıcı adı yoksa
                        if (!dr.Read())
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                            return;
                        }

                        bool aktifMi = Convert.ToBoolean(dr["Aktif"]);
                        /*string sifreHash = dr["SifreHash"].ToString();


                        if (!BCrypt.Net.BCrypt.Verify(sifre, sifreHash))
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                            return;
                        }
                       */

                        // Kullanıcı pasifse
                        if (!aktifMi)
                        {
                            MessageBox.Show(
                                "Bu hesap pasif durumda olduğu için şu anda sisteme giriş yapılamıyor.\nLütfen yönetici ile iletişime geçin."
                            );
                            return;
                        }

                        // Şifre yanlışsa
                        

                        // ===== BURASI BAŞARILI GİRİŞ =====
                        girisTamamlandi = true;

                        pictureBox2.Visible = true;
                        pictureBox3.Visible = true;
                        pictureBox4.Visible = true;
                        pictureBox5.Visible = true;
                        checkBox1.Visible = true;
                        checkBox2.Visible = true;
                        checkBox3.Visible = true;
                        checkBox4.Visible = true;
                        btnDevam.Visible = true;
                        lblTalimat.Visible = true;

                        this.Width = 872;
                        this.Height = 674;

                        ResimleriGetirOgretmen();
                    }
                }

            }
        }

        private void ResimleriGetirOgretmen()
        {
            string klasor = @"C:\Users\omerd\OneDrive\Masaüstü\öğretmenresimler";
            string[] tumResimler = Directory.GetFiles(klasor, "*.png");

            Random rnd = new Random();

            var nesneTurleri = tumResimler
                .Select(x => Regex.Replace(Path.GetFileNameWithoutExtension(x), @"\s*\(.*?\)", "").ToLower())
                .Distinct()
                .ToList();

            var dogruNesneTurleri = nesneTurleri.OrderBy(x => rnd.Next()).Take(2).ToArray();

            List<string> dogruResimler = new List<string>();
            foreach (var tur in dogruNesneTurleri)
            {
                var resimler = tumResimler
                    .Where(x => Regex.Replace(Path.GetFileNameWithoutExtension(x), @"\s*\(.*?\)", "").ToLower() == tur)
                    .ToArray();

                if (resimler.Length > 0)
                {
                    string secilen = resimler[rnd.Next(resimler.Length)];
                    dogruResimler.Add(secilen);
                }
            }

            var yanlisResimler = tumResimler
                .Except(dogruResimler)
                .OrderBy(x => rnd.Next())
                .Take(4 - dogruResimler.Count)
                .ToList();

            var secilen4 = dogruResimler.Concat(yanlisResimler).OrderBy(x => rnd.Next()).ToArray();

            PictureBox[] boxes = { pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };

            for (int i = 0; i < 4; i++)
            {
                boxes[i].Image = Image.FromFile(secilen4[i]);
                string nesneAdi = Regex.Replace(Path.GetFileNameWithoutExtension(secilen4[i]), @"\s*\(.*?\)", "").ToLower();
                checkBoxes[i].Tag = dogruNesneTurleri.Contains(nesneAdi);

                int index = i;
                boxes[i].Click += (s, e) => checkBoxes[index].Checked = !checkBoxes[index].Checked;
            }

            lblTalimat.Text = $"Lütfen {string.Join(" ve ", dogruNesneTurleri)} resimlerini işaretleyin";
        }

        private void btnDevam_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };
            bool dogruMu = true;
            bool herhangiSecildiMi = false;

            for (int i = 0; i < 4; i++)
            {
                bool isDogru = (bool)checkBoxes[i].Tag;

                if (checkBoxes[i].Checked)
                    herhangiSecildiMi = true;

                if ((checkBoxes[i].Checked && !isDogru) || (!checkBoxes[i].Checked && isDogru))
                    dogruMu = false;
            }

            if (!herhangiSecildiMi)
            {
                MessageBox.Show("Lütfen en az bir resim seçin!");
                return;
            }

            if (dogruMu)
            {
                MessageBox.Show("Doğru seçim! Giriş başarılı.");

                // Giriş yapan öğretmenin ID'sini al
                int ogretmenID = 0;
                using (SqlConnection conn = new SqlConnection(con))
                {
                    conn.Open();
                    string query = "SELECT OgretmenID FROM OGRETMEN_GIRIS WHERE KullaniciAdi=@kullanici";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@kullanici", txtKullaniciAdi.Text);
                        ogretmenID = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }

                FrmOgretmen frm = new FrmOgretmen(ogretmenID);
                frm.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Yanlış seçim, tekrar deneyin!");
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (!girisTamamlandi)
            {
                Anasayfa frm = new Anasayfa();
                this.Hide();
                frm.Show();
            }
            else
            {
                girisTamamlandi = false;

                txtKullaniciAdi.Enabled = true;
                mskSifre.Enabled = true;
                btnGiris.Enabled = true;

                lblTalimat.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                btnDevam.Visible = false;

                this.Width = 816;
                this.Height = 489;
            }
        }
    }
}
