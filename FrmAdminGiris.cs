using Microsoft.Data.SqlClient;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Öğrenci_Not_Kayıt_Sistemi
{
    public partial class FrmAdminGiris : Form
    {
        private string connectionString = "Server=AKALI;Database=OgrenciNotKayitSistemi;Trusted_Connection=True;TrustServerCertificate=True;";
        private string generatedOTP;

        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private async void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtRecaptchaToken.Hide();

            // WebView2’yi hazırla
            await webViewRecaptcha.EnsureCoreWebView2Async();
            webViewRecaptcha.Width = 320;
            webViewRecaptcha.Height = 150;
            webViewRecaptcha.Visible = true;

            // Test site key (Google resmi)
            string siteKey = "6LdMEtorAAAAAB7VbivdpkSVMLc1psC8pFPZnQGJ";

            string html = $@"
<html>
<head>
  <script src='https://www.google.com/recaptcha/api.js'></script>
</head>
<body>
  <form id='recaptchaForm'>
    <div class='g-recaptcha' data-sitekey='{siteKey}' data-callback='onRecaptchaSuccess'></div>
    <script>
      function onRecaptchaSuccess(token) {{
        window.chrome.webview.postMessage(token);
      }}
    </script>
  </form>
</body>
</html>";

            // Token alındığında TextBox’a yaz
            webViewRecaptcha.CoreWebView2.WebMessageReceived += (s, args) =>
            {
                string token = args.TryGetWebMessageAsString();
                txtRecaptchaToken.Text = token;
            };

            webViewRecaptcha.NavigateToString(html);
        }

        private async void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT AdminID, Email, Telefon FROM ADMINGIRISBILGILERI WHERE KullaniciAdi=@ka AND SifreHash=@sifre";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ka", kullaniciAdi);
                    cmd.Parameters.AddWithValue("@sifre", sifre);

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            lblBilgi.Text = "Kullanıcı adı veya şifre yanlış!";
                            return;
                        }

                        string email = dr["Email"].ToString();
                        string telefon = dr["Telefon"].ToString();

                        // reCAPTCHA doğrulaması
                        string token = txtRecaptchaToken.Text;
                        if (string.IsNullOrEmpty(token))
                        {
                            lblBilgi.Text = "Lütfen reCAPTCHA’yı çözün!";
                            return;
                        }

                        bool recaptchaSuccess = await VerifyRecaptcha(token);
                        if (!recaptchaSuccess)
                        {
                            lblBilgi.Text = "reCAPTCHA doğrulaması başarısız!";
                            return;
                        }

                        // OTP oluştur ve göster
                        generatedOTP = GenerateOTP();
                        SendOTP(email, telefon, generatedOTP);
                        lblBilgi.Text = "OTP gönderildi. Lütfen giriniz.";
                        txtOTP.Enabled = true;
                        btnOTPGonder.Enabled = true;
                    }
                }
            }
        }

        private void btnOTPGonder_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text == generatedOTP)
            {
                FrmAdminPanel frm = new FrmAdminPanel();
                frm.Show();
                this.Hide();
            }
            else
            {
                lblBilgi.Text = "OTP yanlış, tekrar deneyin!";
            }
        }

        private string GenerateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        private void SendOTP(string email, string telefon, string otp)
        {
            MessageBox.Show($"OTP: {otp}");
        }

        private async Task<bool> VerifyRecaptcha(string token)
        {
            string secretKey = "6LdMEtorAAAAAK1Oe8EeiPQyL0vAupuYGvjhVHi7"; // Test secret key
            using var client = new HttpClient();
            var values = new Dictionary<string, string>
            {
                { "secret", secretKey },
                { "response", token }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync("https://www.google.com/recaptcha/api/siteverify", content);
            var responseString = await response.Content.ReadAsStringAsync();
            var json = JsonSerializer.Deserialize<Dictionary<string, object>>(responseString);

            return json != null && json.ContainsKey("success") && (bool)json["success"];
        }
    }
}
