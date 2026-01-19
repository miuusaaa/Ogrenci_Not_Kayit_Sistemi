using Microsoft.Data.SqlClient;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Security.Policy;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmAdminGiris : Form
    {
        private string connectionString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private string kullaniciAdi;
        private string query = @"SELECT AdminID, SifreHash, IlkGiris
                 FROM ADMINGIRISBILGILERI
                 WHERE AdminID = @id";


        public FrmAdminGiris()
        {
            InitializeComponent();


            this.AutoScaleMode = AutoScaleMode.None;
            this.Size = new Size(816, 350);

        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

            panelIlkGiris.Visible = false;
            panelResimler.Visible = false;
            panelOTP.Visible = false;

            this.AutoSize = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            mskSifre.PasswordChar = '*';
            mskYeniSifre.PasswordChar = '*';
            mskYeniSifreTekrar.PasswordChar = '*';

        }

        private bool girisTamamlandi = false;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = mskSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                            return;
                        }

                        string hash = dr["SifreHash"].ToString();


                        if (!BCrypt.Net.BCrypt.Verify(sifre, hash))
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                            return;
                        }

                        panel1.Visible = false;
                        panelResimler.Visible = true;
                        ResimleriGetirOgretmen();

                    }
                }

            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa frm = new Anasayfa();
            this.Hide();
            frm.Show();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (mskYeniSifre.Text != mskYeniSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            if (mskYeniSifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır.");
                return;
            }

            string yeniHash = BCrypt.Net.BCrypt.HashPassword(mskYeniSifre.Text);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = @"UPDATE ADMINGIRISBILGILERI
                       SET SifreHash = @hash,
                           IlkGiris = 0
                       WHERE AdminID = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@hash", yeniHash);
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Şifre başarıyla değiştirildi.");

            this.Hide();
            FrmAdminGiris frm = new FrmAdminGiris();
            frm.Show();

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

            PictureBox[] boxes = { pb1, pb2, pb3, pb4 };
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
                MessageBox.Show("Doğru seçim!");
                panelResimler.Visible = false;

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", kullaniciAdi);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read()) // 🔴 BU ŞART
                            {
                                bool ilkGiris = Convert.ToBoolean(dr["IlkGiris"]);

                                if (ilkGiris)
                                {
                                    MessageBox.Show("Sisteme ilk kez giriş yaptığınızdan şifrenizi değiştirmelisiniz.");
                                    panelIlkGiris.Visible = true;
                                }
                                else
                                {
                                    panelOTP.Visible = true;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı bilgisi alınamadı.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Yanlış seçim, tekrar deneyin!");
            }
        }

        private void btnOtpDogrula_Click(object sender, EventArgs e)
        {

        }
    }
}
