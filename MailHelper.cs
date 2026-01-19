using System.Net;
using System.Net.Mail;

public static class MailHelper
{
    public static void SendPasswordMail(string toMail, string adminID, string password)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("omerdemir1357911@gmail.com", "Okul Yönetim Sistemi");
        mail.To.Add(toMail);
        mail.Subject = "Admin Giriş Bilgileriniz";
        mail.Body = $@"
Merhaba,

Admin hesabınız oluşturulmuştur.y

Kullanıcı Adı: {adminID}
Şifre: {password}

İlk girişten sonra şifrenizi değiştirmenizi öneririz.

İyi çalışmalar.
";

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential(
         "omerdemir1357911@gmail.com",
         "ubgtfxozzihihnjf"
     ),
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false
        };

        smtp.Send(mail);
    }
}
