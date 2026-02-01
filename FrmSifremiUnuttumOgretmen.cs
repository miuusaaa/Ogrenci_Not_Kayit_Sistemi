using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmSifremiUnuttumOgretmen : Form
    {
        private string connectionString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private string gonderilecekEmail;
        private string gonderilecekTelefon;
        private string emailOtp;
        private string telefonOtp;
        private DateTime otpExpireTime;
        private string kullaniciAdi;
        private int denemegirissayisi = 0;
        public FrmSifremiUnuttumOgretmen()
        {
            InitializeComponent();
        }
        private void FrmSifremiUnuttumOgretmen_Load(object sender, EventArgs e)
        {
            this.Size = new Size(930, 290); //panel boşlukları veya panelin kırpılma sorunu buradan ayarlanıyo
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.

            panelKoduDogrula.Visible = false;
            panelSifreGuncelle.Visible = false;
            panelKodGonder.Visible = true;

            txtYeniSifre.PasswordChar = '*';
            txtYeniSifreTekrar.PasswordChar = '*';
        }

        private async void btnKodGonder_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txtKullaniciAdi.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı girin.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = @"SELECT Email, Telefon FROM OGRETMEN_GIRIS WHERE KullaniciAdi = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            MessageBox.Show("Bu kullanıcı adına ait kayıt bulunamadı.");
                            return;
                        }

                        gonderilecekEmail = dr["Email"].ToString();
                        gonderilecekTelefon = dr["Telefon"].ToString();
                    }
                }
            }
            panelKodGonder.Visible = false;
            panelKoduDogrula.Visible = true;

            await OtpUretVeGonderAsync();

            string maskedEmail = MaskEmail(gonderilecekEmail);
            string maskedPhone = MaskPhone(gonderilecekTelefon);

            lblOtpBilgi.Text = $"{maskedEmail} ve {maskedPhone} numarasına doğrulama kodu gönderildi.";
        }

        private void btnKoduDogrula_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > otpExpireTime)
            {
                MessageBox.Show("Kod süresi doldu.");
                return;
            }

            if (txtKod.Text.Trim() != emailOtp)
            {
                denemegirissayisi++;

                if (denemegirissayisi == 3)
                {
                    using (SqlConnection cs = new SqlConnection(connectionString))
                    {
                        cs.Open();

                        string sql = @"UPDATE OGRETMEN_GIRIS SET Aktif = 0 WHERE KullaniciAdi = @id";

                        using (SqlCommand cd = new SqlCommand(sql, cs))
                        {
                            cd.Parameters.AddWithValue("@id", kullaniciAdi);
                            cd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Kodu 3 kez yanlış girdiğiniz için hesabınız blokelendi. Lütfen adminle iletişime geçiniz!");
                    txtKullaniciAdi.Clear();
                    this.Hide();
                    FrmOgretmenGiris frm = new FrmOgretmenGiris();
                    frm.Show();
                    return;

                }
                MessageBox.Show("Kod hatalı.");
                return;
            }

            MessageBox.Show("Kod doğrulandı!");
            panelKoduDogrula.Visible = false;
            panelSifreGuncelle.Visible = true;
        }

        private void btnSifreyiGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            if (txtYeniSifre.Text.Length < 8)
            {
                MessageBox.Show("Şifre en az 8 karakter olmalıdır.");
                return;
            }

            string yeniHash = BCrypt.Net.BCrypt.HashPassword(txtYeniSifre.Text);

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = @"UPDATE OGRETMEN_GIRIS
                       SET SifreHash = @hash,
                           IlkGiris = 0
                       WHERE KullaniciAdi = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@hash", yeniHash);
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Şifre başarıyla değiştirildi.");

            this.Hide();
            FrmOgretmenGiris frm = new FrmOgretmenGiris();
            frm.Show();
        }

        private async Task OtpUretVeGonderAsync()
        {
            Random rnd = new Random();

            emailOtp = rnd.Next(100000, 999999).ToString();
            telefonOtp = rnd.Next(100000, 999999).ToString();

            otpExpireTime = DateTime.Now.AddMinutes(5);

            // 📧 MAIL OTP
            MailHelper.mailesifremiUnuttumotpGonder(
                gonderilecekEmail,
                emailOtp
            );

            // 📱 SMS OTP
            await SmsHelper.smseOtpGonder(
                gonderilecekTelefon,
                telefonOtp
            );
        }

        private string MaskEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
                return "****";

            var parts = email.Split('@');
            string name = parts[0];
            string domain = parts[1];

            if (name.Length <= 2)
                name = name[0] + "*";
            else
                name = name.Substring(0, 1) + new string('*', name.Length - 2) + name.Substring(name.Length - 1, 1);

            return name + "@" + domain;
        }

        private string MaskPhone(string phone)
        {
            if (string.IsNullOrEmpty(phone) || phone.Length < 4)
                return "****";

            return phone.Substring(0, 3) + "****" + phone.Substring(phone.Length - 2);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOgretmenGiris frm = new FrmOgretmenGiris();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelKoduDogrula.Visible = false;
            panelKodGonder.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmOgretmenGiris frm = new FrmOgretmenGiris();
            frm.Show();
        }
    }
}
