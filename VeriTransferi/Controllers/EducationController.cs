using Microsoft.AspNetCore.Mvc;
using VeriTransferi.Models;

namespace VeriTransferi.Controllers
{
    public class EducationController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(School school)
        {
            return View();
        }
    }
}
