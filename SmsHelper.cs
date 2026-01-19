using System.Net.Http;
using System.Threading.Tasks;

public static class SmsHelper
{
    public static async Task SendSmsAsync(string phone, string adminID, string password)
    {
        string mesaj = $"Admin hesabınız oluşturuldu. Kullanıcı Adı: {adminID} Şifre: {password}";
        string encodedMesaj = Uri.EscapeDataString(mesaj);
        phone = phone.Replace("+", "").Trim();


        string url = $"https://api.netgsm.com.tr/sms/send/get/" +
                     $"?usercode=NETGSM_USER" +
                     $"&password=NETGSM_PASS" +
                     $"&gsmno={phone}" +
                     $"&message={encodedMesaj}" +
                     $"&msgheader=OKULSISTEMI";

        using (HttpClient client = new HttpClient())
        {
            var response = await client.GetAsync(url);

            string result = await response.Content.ReadAsStringAsync();

            if (!result.StartsWith("00"))
            {
                throw new Exception("SMS gönderilemedi. NetGSM kodu: " + result);
            }
        }
    }
}
