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
using System.IO;



namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmOgretmenGiris : Form
    {
        private string connectionString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private string kullaniciAdi;
        private string query = @"Select OgretmenID,
    KullaniciAdi,
    SifreHash,
    IlkGiris,
    Email,
    Telefon,
    Aktif
FROM OGRETMEN_GIRIS
WHERE KullaniciAdi = @id";
        private string emailOtp;
        private string telefonOtp;
        private DateTime otpExpireTime;
        private string gonderilecekEmail;
        private string gonderilecekTelefon;
        private int denemegirissayisi = 0;
        private int denemeotpsayisi = 0;
        private int denemeresimsayisi = 0;

        public FrmOgretmenGiris()
        {
            InitializeComponent();
        }

        private void FrmOgretmenGiris_Load(object sender, EventArgs e)
        {

            this.AutoScaleMode = AutoScaleMode.None;
            this.Size = new Size(816, 400); //panel boşlukları veya panelin kırpılma sorunu buradan ayarlanıyo
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.

            panelIlkGiris.Visible = false;
            panelResimler.Visible = false;
            panelOTP.Visible = false;
            panelGiris.Visible = true;

            this.AutoSize = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            mskSifre.PasswordChar = '*';
            mskYeniSifre.PasswordChar = '*';
            mskYeniSifreTekrar.PasswordChar = '*';

        }


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
                            denemegirissayisi++;

                            if (denemegirissayisi == 3)
                            {
                                panelGirisGuvenliBlokeEt(kullaniciAdi);  
                                return;
                            }

                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                            return;
                        }

                        bool aktifMi = dr["Aktif"] != DBNull.Value && Convert.ToBoolean(dr["Aktif"]);

                        string hash = dr["SifreHash"].ToString();


                        if (!BCrypt.Net.BCrypt.Verify(sifre, hash))
                        {
                            denemegirissayisi++;

                            if (denemegirissayisi == 3)
                            {
                                panelGirisGuvenliBlokeEt(kullaniciAdi);
                                return;
                            }

                            MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                            return;
                        }

                        if (!aktifMi)
                        {
                            MessageBox.Show(
                                "Bu hesap pasif durumda olduğu için şu anda sisteme giriş yapılamıyor.\nLütfen yönetici ile iletişime geçin."
                            );
                            return;
                        }

                        panelGiris.Visible = false;
                        panelResimler.Visible = true;
                        ResimleriGetirOgretmen();
                        denemegirissayisi = 0;
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
            this.Close();

        }

        private void ResimleriGetirOgretmen()
        {
            List<(string nesneAdi, byte[] resim)> tumResimler = new List<(string, byte[])>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string sql = "SELECT NesneAdi, Resim FROM OGRETMEN_CAPTCHA_RESIMLERI";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        tumResimler.Add((
                            dr["NesneAdi"].ToString(),
                            (byte[])dr["Resim"]
                        ));
                    }
                }
            }

            Random rnd = new Random();

            string Temizle(string ad)
            {
                return Regex.Replace(ad, @"\s*\(.*?\)", "").ToLower();
            }

            var nesneTurleri = tumResimler
                .Select(x => Temizle(x.nesneAdi))
                .Distinct()
                .ToList();

            // 2 tür seç
            var dogruTurler = nesneTurleri
                .OrderBy(x => rnd.Next())
                .Take(2)
                .ToList();

            List<(string nesneAdi, byte[] resim)> dogruResimler = new List<(string, byte[])>();

            // 🔑 Her türden en az 1 resim garanti
            foreach (var tur in dogruTurler)
            {
                var resim = tumResimler
                    .Where(x => Temizle(x.nesneAdi) == tur)
                    .OrderBy(x => rnd.Next())
                    .First();

                dogruResimler.Add(resim);
            }

            // Toplam doğru adedi (2–4 arası)
            int toplamDogruAdet;
            if (rnd.Next(0, 100) < 25)
                toplamDogruAdet = 4;
            else
                toplamDogruAdet = rnd.Next(1, 4); // 2 veya 3

            int eklenecekDogru = toplamDogruAdet - dogruResimler.Count;

            if (eklenecekDogru > 0)
            {
                var ekstraDogru = tumResimler
                    .Where(x => dogruTurler.Contains(Temizle(x.nesneAdi))
                             && !dogruResimler.Contains(x))
                    .OrderBy(x => rnd.Next())
                    .Take(eklenecekDogru)
                    .ToList();

                dogruResimler.AddRange(ekstraDogru);
            }

            int kalan = 4 - dogruResimler.Count;

            var yanlisResimler = tumResimler
                .Where(x => !dogruTurler.Contains(Temizle(x.nesneAdi)))
                .OrderBy(x => rnd.Next())
                .Take(kalan)
                .ToList();

            var secilen4 = dogruResimler
                .Concat(yanlisResimler)
                .OrderBy(x => rnd.Next())
                .ToList();

            PictureBox[] boxes = { pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };

            for (int i = 0; i < 4; i++)
            {
                boxes[i].Image = ByteToImage(secilen4[i].resim);

                string temizAd = Temizle(secilen4[i].nesneAdi);
                checkBoxes[i].Tag = dogruTurler.Contains(temizAd);

                int index = i;
                boxes[i].Click += (s, e) =>
                {
                    checkBoxes[index].Checked = !checkBoxes[index].Checked;
                };
            }

            lblTalimat.Text = $"Lütfen {string.Join(" ve ", dogruTurler)} resimlerini işaretleyin.";
        }

        private Image ByteToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }

        private async void btnDevam_Click(object sender, EventArgs e)
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
                CheckBoxlariTemizle();
                denemeresimsayisi = 0;

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
                                bool ilkGiris = dr["IlkGiris"] != DBNull.Value && Convert.ToBoolean(dr["IlkGiris"]);
                                gonderilecekEmail = dr["Email"].ToString();
                                gonderilecekTelefon = dr["Telefon"].ToString();


                                if (ilkGiris)
                                {
                                    MessageBox.Show("Sisteme ilk kez giriş yaptığınızdan şifrenizi değiştirmelisiniz.");
                                    panelIlkGiris.Visible = true;
                                }
                                else
                                {
                                    panelIlkGiris.Visible = false;
                                    panelOTP.Visible = true;
                                    MessageBox.Show("E-postanıza ve telefonunuza şifreler gönderildi!");
                                    await OtpUretVeGonderAsync();
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
                denemeresimsayisi++;

                if (denemeresimsayisi == 3)
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
                    MessageBox.Show("3 kez eksik veya yanlış seçim yaptığınız için hesabınız blokelendi. Lütfen adminle iletişime geçiniz!");
                    txtKullaniciAdi.Clear();
                    mskSifre.Clear();
                    panelResimler.Visible = false;
                    panelGiris.Visible = true;
                    return;
                }

                MessageBox.Show("Yanlış veya eksik seçim,lütfen tekrar deneyin!");
                CheckBoxlariTemizle();
                ResimleriGetirOgretmen();
            }
        }

        private void CheckBoxlariTemizle()
        {
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };

            foreach (CheckBox cb in checkBoxes)
            {
                cb.Checked = false;
            }
        }

        private async Task OtpUretVeGonderAsync()
        {
            Random rnd = new Random();

            emailOtp = rnd.Next(100000, 999999).ToString();
            telefonOtp = rnd.Next(100000, 999999).ToString();

            otpExpireTime = DateTime.Now.AddMinutes(5);

            // 📧 MAIL OTP
            MailHelper.maileotpGonder(
                gonderilecekEmail,
                emailOtp
            );

            // 📱 SMS OTP
            await SmsHelper.smseOtpGonder(
                gonderilecekTelefon,
                telefonOtp
            );
        }

        private void btnOtpDogrula_Click(object sender, EventArgs e)
        {
            if (DateTime.Now > otpExpireTime)
            {
                MessageBox.Show("Doğrulama kodlarının süresi dolmuş.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmailOtp.Text)
                //|| string.IsNullOrWhiteSpace(txtTelefonOtp.Text)  => SONRA AYARLA
                )
            {
                MessageBox.Show("Lütfen e-postanıza ve telefonunuza gelen kodları eksiksiz girin.");
                return;
            }

            if (txtEmailOtp.Text.Trim() != emailOtp
                // ||txtTelefonOtp.Text.Trim() != telefonOtp  => SONRA AYARLA
                )
            {
                denemeotpsayisi++;

                if (denemeotpsayisi == 3)
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
                    MessageBox.Show("Doğrulama kodunu 3 kez yanlış girdiğinizden ötürü hesabınız blokelendi.Lütfen adminle iletişime geçiniz!");
                    txtKullaniciAdi.Clear();
                    mskSifre.Clear();
                    panelOTP.Visible = false;
                    panelGiris.Visible = true;
                    return;
                }
                MessageBox.Show("E-posta veya telefon doğrulama kodu hatalı.");
                return;
            }

            MessageBox.Show("Doğrulama başarılı.");
            denemeotpsayisi = 0;

            int ogretmenID;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string sql = @"SELECT OgretmenID FROM OGRETMEN_GIRIS WHERE KullaniciAdi = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    object result = cmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Öğretmen bilgisi bulunamadı.");
                        return;
                    }

                    ogretmenID = Convert.ToInt32(result);
                }
            }


            FrmOgretmen frm = new FrmOgretmen(ogretmenID);
            frm.Show();
            this.Hide();

        }
        private async void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttumOgretmen frm = new FrmSifremiUnuttumOgretmen();
            this.Hide();
            frm.Show();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            panelResimler.Visible = false;
            panelGiris.Visible = true;
            txtKullaniciAdi.Clear();
            mskSifre.Clear();
            CheckBoxlariTemizle();
        }

        private void panelGirisGuvenliBlokeEt(string kullaniciAdi)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string checkSql = "SELECT COUNT(*) FROM OGRETMEN_GIRIS WHERE KullaniciAdi = @id";

                using (SqlCommand checkCmd = new SqlCommand(checkSql, con))
                {
                    checkCmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                        return;
                    }
                }

                string blockSql = "UPDATE OGRETMEN_GIRIS SET Aktif = 0 WHERE KullaniciAdi = @id";

                using (SqlCommand blockCmd = new SqlCommand(blockSql, con))
                {
                    blockCmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    blockCmd.ExecuteNonQuery();
                }

                MessageBox.Show("3 kez yanlış giriş denemesinden dolayı hesabınız bloke edilmiştir.Lütfen adminle iletişime geçin");
                txtKullaniciAdi.Clear() ;
                mskSifre.Clear();
            }
        }

    }
}
