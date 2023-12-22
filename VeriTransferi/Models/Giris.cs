using Microsoft.AspNetCore.Mvc;

namespace VeriTransferi.Models
{
    public class Giris
    {
        /*
        Controller => Login Sayfası => Kullanıcı Adı ve Şifre
        Eğer Kullanıcı Adı ve Şifre Kriterlere uyuyor ise yeni bir sayfada "Hoş Geldiniz"
        Eğer uymuyor ise aynı sayfa görüntülensin
        */

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
