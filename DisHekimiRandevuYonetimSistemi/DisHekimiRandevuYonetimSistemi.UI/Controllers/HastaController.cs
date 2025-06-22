using Microsoft.AspNetCore.Mvc;

namespace DisHekimiRandevuYonetimSistemi.UI.Controllers
{
    public class HastaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
