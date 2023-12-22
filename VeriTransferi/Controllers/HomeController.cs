using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Reflection.Emit;
using VeriTransferi.Models;

namespace VeriTransferi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Giris(string Email, string Sifre)
        {
            return View();
        }

        public IActionResult Kayit(string Ad, string Soyad, DateTime DogumTarihi, string ErkekCinsiyeti, string KadınCinsiyeti, string OgrenimDurumu, string Evli)
        {
            return View();
        }

        /*
         Isim
        SoyIsim
        Doğum Tarihi
        Cinsiyet radiobutton
        Öğrenim Durumu(combobox)
        Medeni Durum(Checkbox - Evli)
         
         */

        /*
         Bir tane Controller'ınız olsun. Default da bu controller'ın Index sayfası açılsın.
         Bu sayfa da Model ile school Datalarını alın => Id, Ad, Şehir
         */



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}