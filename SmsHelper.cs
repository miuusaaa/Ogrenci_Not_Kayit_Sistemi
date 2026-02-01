using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class SmsHelper
{
    private const string BASE_URL = "https://4kmnrp.api.infobip.com/sms/2/text/advanced";
    private const string API_KEY = "a9d7e04bcdd68c27d3ef20f5e13a96bb-67c16d1c-9e3e-46d0-b076-4b2a1df6f0e2";
    private const string SENDER = "TEST ";

    // 🔹 İLK GİRİŞ SMS
    public static async Task smseIlkGirisBilgileriGonder(string phone, string adminID, string password)
    {
        string mesaj = $"Admin hesabınız oluşturuldu. Kullanıcı Adı: {adminID} Şifre: {password}";
        await SmsGonder(phone, mesaj);
    }

    // 🔹 OTP SMS
    public static async Task smseOtpGonder(string phone, string otp)
    {
        string mesaj = $"Giriş doğrulama kodunuz: {otp}. Kod 5 dakika geçerlidir.";
        await SmsGonder(phone, mesaj);
    }

    // 🔹 ORTAK SMS METODU
    private static async Task SmsGonder(string phone, string mesaj)
    {
       

        var payload = new
        {
            messages = new[]
            {
            new
            {
                from = SENDER,
                destinations = new[]
                {
                    new { to = phone }
                },
                text = mesaj
            }
        }
        };

        string json = JsonSerializer.Serialize(payload);

        using (HttpClient client = new HttpClient())
        {
            client.Timeout = TimeSpan.FromSeconds(10);

            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add(
                "Authorization",
                $"App {API_KEY}"
            );
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response;

            try
            {
                response = await client.PostAsync(BASE_URL, content);
            }
            catch (TaskCanceledException)
            {
                MessageBox.Show(
                    "SMS servisine ulaşılamadı (zaman aşımı).",
                    "SMS Gönderilemedi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Beklenmeyen Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // 🔴 RESPONSE BODY OKUMA
            string responseBody = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(
                    $"SMS API başarılı cevap verdi.\n\nHTTP: {(int)response.StatusCode}\n\nRESPONSE:\n{responseBody}",
                    "SMS Gönderildi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    $"SMS gönderilemedi.\n\nHTTP: {(int)response.StatusCode}\n\nRESPONSE:\n{responseBody}",
                    "SMS Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

}
