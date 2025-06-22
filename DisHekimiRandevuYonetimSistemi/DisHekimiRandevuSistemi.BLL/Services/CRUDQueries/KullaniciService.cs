using DisHekimiRandevuSistemi.BLL.DTOs;
using DisHekimiRandevuSistemi.BLL.Services.İnterfaces;
using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.Services.CRUDQueries
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciRepository<Kullanici> _repo;

        public KullaniciService(IKullaniciRepository<Kullanici> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Kullanici> HastalariListele()
        {
            return _repo.HepsiniGetir().Where(k => k.Rol == DAL.Enums.RolEnum.Hasta);
        }

        public void HastaOlustur(KullaniciCreateDTO dto)
        {
            var hasta = new Kullanici
            {
                AdSoyad = dto.AdSoyad,
                Email = dto.Email,
                Sifre = dto.Sifre,
                TelefonNumarasi = dto.TelefonNumarasi,
                Rol = DAL.Enums.RolEnum.Hasta
            };
            _repo.Ekle(hasta);
        }
    }
}
