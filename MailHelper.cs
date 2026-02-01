using System.Net;
using System.Net.Mail;

public static class MailHelper
{
    public static void maileIlkGirisBilgileriGonder(string toMail, string adminID, string password)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("omerdemir1357911@gmail.com", "Okul Yönetim Sistemi");
        mail.To.Add(toMail);
        mail.Subject = "Admin Giriş Bilgileriniz";
        mail.Body = $@"
Merhaba,

Admin hesabınız oluşturulmuştur.

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

    public static void maileotpGonder(string toMail, string otp)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("omerdemir1357911@gmail.com", "Okul Yönetim Sistemi");
        mail.To.Add(toMail);
        mail.Subject = "Güvenlik Doğrulama Kodu";
        mail.Body = $@"
Merhaba,

Sisteme girişinizi doğrulamak için tek kullanımlık kodunuz:

OTP Kodu: {otp}

Bu kod 5 dakika boyunca geçerlidir.
Eğer bu işlemi siz yapmadıysanız lütfen dikkate almayın.
";

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential(
                "omerdemir1357911@gmail.com",
                "ubgtfxozzihihnjf"
            ),
            EnableSsl = true
        };

        smtp.Send(mail);
    }

    public static void mailesifremiUnuttumotpGonder(string toMail, string otp)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("omerdemir1357911@gmail.com", "Okul Yönetim Sistemi");
        mail.To.Add(toMail);
        mail.Subject = "Güvenlik Doğrulama Kodu";
        mail.Body = $@"
Merhaba,

Unuttuğunuz şifrenizi sıfırlamayı doğrulamak için tek kullanımlık kodunuz:

OTP Kodu: {otp}

Bu kod 5 dakika boyunca geçerlidir.
Eğer bu işlemi siz yapmadıysanız lütfen dikkate almayın.
";

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
        {
            Credentials = new NetworkCredential(
                "omerdemir1357911@gmail.com",
                "ubgtfxozzihihnjf"
            ),
            EnableSsl = true
        };

        smtp.Send(mail);
    }

    public static void maileIlkGirisBilgileriGonderOgretmen(string toMail, string adminID, string password)
    {
        MailMessage mail = new MailMessage();
        mail.From = new MailAddress("omerdemir1357911@gmail.com", "Okul Yönetim Sistemi");
        mail.To.Add(toMail);
        mail.Subject = "Admin Giriş Bilgileriniz";
        mail.Body = $@"
Merhaba,

Öğretmen hesabınız oluşturulmuştur.

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
