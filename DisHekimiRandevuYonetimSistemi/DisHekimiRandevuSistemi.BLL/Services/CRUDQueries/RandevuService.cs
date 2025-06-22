using DisHekimiRandevuSistemi.BLL.DTOs;
using DisHekimiRandevuSistemi.BLL.Services.Interfaces;
using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.Services.CRUDQueries
{
    public class RandevuService : IRandevuService
    {
        private readonly IRandevuRepository<Randevu> _randevuRepo;


        public RandevuService(IRandevuRepository<Randevu> randevuRepo)
        {
            _randevuRepo = randevuRepo;
        }

        public IEnumerable<Randevu> BekleyenRandevulariListele()
        {
            return _randevuRepo.HepsiniGetir().Where(r => r.RandevuDurum == DAL.Enums.RandevuDurumEnum.Bekliyor);
        }

        public IEnumerable<Randevu> BugunkuRandevulariListele()
        {
            return _randevuRepo.HepsiniGetir().Where(r=>r.RandevuTarihi.Date==DateTime.Now.Date);
        }

        public IEnumerable<Randevu> OnaylananRandevulariListele()
        {
            return _randevuRepo.HepsiniGetir().Where(r => r.RandevuDurum == DAL.Enums.RandevuDurumEnum.Onaylandi);
        }

        public void RandevuDoktorGuncelle(int randevuId, RandevuDoktorUpdateDTO dto)
        {
            var guncellenecekRandevu = _randevuRepo.GetirById(randevuId);
            if(guncellenecekRandevu!=null && guncellenecekRandevu.RandevuTarihi.Date >= DateTime.Now.Date)
            {
                guncellenecekRandevu.RandevuDurum=dto.RandevuDurum;
                if(dto.RandevuDurum==DAL.Enums.RandevuDurumEnum.Onaylandi)
                {
                    guncellenecekRandevu.OnayTarihi = DateTime.Now;
                }
                _randevuRepo.Guncelle(guncellenecekRandevu);
            }
        }

        public void RandevuHastaGuncelle(int randevuId, RandevuHastaUpdateDTO dto)
        {
            var guncellenecekRandevu = _randevuRepo.GetirById(randevuId);
            if(guncellenecekRandevu!=null && guncellenecekRandevu.RandevuDurum == DAL.Enums.RandevuDurumEnum.Bekliyor)
            {
                guncellenecekRandevu.HizmetId= dto.HizmetId;
                guncellenecekRandevu.RandevuTarihi = dto.RandevuTarihi;
            }
            _randevuRepo.Guncelle(guncellenecekRandevu);
        }

        public void RandevuOlustur(int kullaniciId, RandevuCreateDTO dto)
        {

            var randevu = new Randevu
            {
                KullaniciId= kullaniciId,
                HizmetId = dto.HizmetId,
                RandevuTarihi = dto.RandevuTarihi,
                RandevuDurum = DAL.Enums.RandevuDurumEnum.Bekliyor
            };
            _randevuRepo.Ekle(randevu);
        }

        public void RandevuSil(int randevuId)
        {
            var randevu = _randevuRepo.GetirById(randevuId);
            if(randevu!= null && randevu.RandevuDurum==DAL.Enums.RandevuDurumEnum.Bekliyor)
            {
                _randevuRepo.Sil(randevuId);
            }
           
        }

        public IEnumerable<Randevu> ReddedilenRandevulariListele()
        {
            return _randevuRepo.HepsiniGetir().Where(r => r.RandevuDurum == DAL.Enums.RandevuDurumEnum.Reddedildi);
        }

        public IEnumerable<Randevu> TumRandevulariListele()
        {
            return _randevuRepo.HepsiniGetir();
        }
    }
}
