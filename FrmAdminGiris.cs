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
        private string query = @"SELECT AdminID, SifreHash, IlkGiris ,Email, Telefon , Aktiflik
                 FROM ADMINGIRISBILGILERI
                 WHERE AdminID = @id";
        private string emailOtp;
        private string telefonOtp;
        private DateTime otpExpireTime;
        private string gonderilecekEmail;
        private string gonderilecekTelefon;
        private int denemegirissayisi = 0;
        private int denemeotpsayisi = 0;
        private int denemeresimsayisi = 0;


        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            this.Size = new Size(816, 413); //panel boşlukları veya panelin kırpılma sorunu buradan ayarlanıyo
            this.FormBorderStyle = FormBorderStyle.FixedSingle; //formu kullanıcı büyütmesin istiyorsan kullan.
            panelIlkGiris.Visible = false;
            panelResimler.Visible = false;
            panelOTP.Visible = false;

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

                        bool aktifMi = dr["Aktiflik"] != DBNull.Value && Convert.ToBoolean(dr["Aktiflik"]);

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

            PictureBox[] boxes = { pb1, pb2, pb3, pb4 };
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

        private void CheckBoxlariTemizle()
        {
            CheckBox[] checkBoxes = { checkBox1, checkBox2, checkBox3, checkBox4 };

            foreach (CheckBox cb in checkBoxes)
            {
                cb.Checked = false;
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
                CheckBoxlariTemizle();
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
                    panelGirisGuvenliBlokeEt(kullaniciAdi);
                    panelResimler.Visible = false;
                    panelGiris.Visible = true;
                    return;
                }

                MessageBox.Show("Yanlış veya eksik seçim, lütfen tekrar deneyin!");
                CheckBoxlariTemizle();
                ResimleriGetirOgretmen();
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
                    panelGirisGuvenliBlokeEt(kullaniciAdi);
                    panelOTP.Visible = false;
                    panelGiris.Visible = true;
                    return;
                }
                MessageBox.Show("E-posta veya telefon doğrulama kodu hatalı.");
                return;
            }

            MessageBox.Show("Doğrulama başarılı.");

            FrmAdminPanel frm = new FrmAdminPanel();
            frm.Show();
            this.Hide();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            FrmSifremiUnuttumAdmin frm = new FrmSifremiUnuttumAdmin();
            this.Hide();
            frm.Show();
        }

        private void btnGERİ_Click(object sender, EventArgs e)
        {
            panelResimler.Visible = false;
            panelGiris.Visible = true;
            CheckBoxlariTemizle();
            txtKullaniciAdi.Clear();
            mskSifre.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           panelOTP.Visible = false;
           panelGiris.Visible = true;
           txtKullaniciAdi.Clear();
           mskSifre.Clear();
        }

        private void panelGirisGuvenliBlokeEt(string kullaniciAdi)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // 1️⃣ Kullanıcı var mı kontrolü
                string checkUserSql = "SELECT COUNT(*) FROM ADMINGIRISBILGILERI WHERE AdminID = @id";

                using (SqlCommand checkCmd = new SqlCommand(checkUserSql, con))
                {
                    checkCmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış!");
                        return;
                    }
                }

                // 2️⃣ Aktif admin sayısını al
                int aktifAdminSayisi;

                string aktifCountSql = "SELECT COUNT(*) FROM ADMINGIRISBILGILERI WHERE Aktiflik = 1";

                using (SqlCommand countCmd = new SqlCommand(aktifCountSql, con))
                {
                    aktifAdminSayisi = (int)countCmd.ExecuteScalar();
                }

                // 3️⃣ Eğer tek aktif admin ise BLOKE ETME
                if (aktifAdminSayisi <= 1)
                {
                    MessageBox.Show("Bu hesap bloke edilemez. Sistemde en az bir aktif admin bulunmalıdır.");
                    txtKullaniciAdi.Clear();
                    mskSifre.Clear();
                    return;
                }

                // 4️⃣ Bloke işlemi
                string blockSql = "UPDATE ADMINGIRISBILGILERI SET Aktiflik = 0 WHERE AdminID = @id";

                using (SqlCommand blockCmd = new SqlCommand(blockSql, con))
                {
                    blockCmd.Parameters.AddWithValue("@id", kullaniciAdi);
                    blockCmd.ExecuteNonQuery();
                }

                MessageBox.Show("3 kez yanlış giriş denemesinden dolayı hesabınız bloke edilmiştir. Lütfen sistem yöneticisi ile iletişime geçin.");
                txtKullaniciAdi.Clear();
                mskSifre.Clear();
            }
        }

    }
}
