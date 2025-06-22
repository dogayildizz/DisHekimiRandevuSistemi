using Microsoft.AspNetCore.Mvc;

namespace DisHekimiRandevuYonetimSistemi.UI.Controllers
{
    public class DoktorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
