using Microsoft.AspNetCore.Mvc;
using VeriTransferi.Models;

namespace VeriTransferi.Controllers
{
    public class GirisController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Giris giris)
        {
            if (giris.KullaniciAdi == "Barkın" && giris.Sifre == "123") {
               return View("index1",giris);
            }
            return View();
        }
    }
}
