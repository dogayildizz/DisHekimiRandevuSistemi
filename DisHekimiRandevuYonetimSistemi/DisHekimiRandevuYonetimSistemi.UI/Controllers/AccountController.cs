using DisHekimiRandevuSistemi.BLL.DTOs;
using DisHekimiRandevuSistemi.BLL.Services.İnterfaces;
using DisHekimiRandevuSistemi.DAL.Enums;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DisHekimiRandevuYonetimSistemi.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IKullaniciService _kullaniciService;

        public AccountController(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GirisYap(string email, string sifre)
        {
            var kullanici = _kullaniciService.HastalariListele().FirstOrDefault(h => h.Email == email && h.Sifre == sifre);
            if(kullanici != null)
            {
                HttpContext.Session.SetInt32("KullaniciId", kullanici.Id);
                HttpContext.Session.SetString("AdSoyad",kullanici.AdSoyad);
                HttpContext.Session.SetString("Rol",kullanici.Rol.ToString());

                return kullanici.Rol == RolEnum.Hasta ? RedirectToAction("Index", "Hasta") : kullanici.Rol == RolEnum.Doktor ? RedirectToAction("Index", "Doktor") : RedirectToAction("Index", "Sekreter");
            }
            ViewBag.Hata = "Giriş Başarısız. E-mail ya da şifre hatalı!";
            return View();
        }
        [HttpGet]
        public IActionResult KayitOl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KayitOl(KullaniciCreateDTO dto)
        {
            _kullaniciService.HastaOlustur(dto);
            return RedirectToAction("GirisYap");
        }
    }
}
