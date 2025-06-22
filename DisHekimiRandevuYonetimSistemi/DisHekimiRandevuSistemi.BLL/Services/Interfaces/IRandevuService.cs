using DisHekimiRandevuSistemi.BLL.DTOs;
using DisHekimiRandevuSistemi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.Services.Interfaces
{
    public interface IRandevuService
    {
        void RandevuOlustur(int kullaniciId,RandevuCreateDTO dto);
        void RandevuHastaGuncelle(int randevuId,RandevuHastaUpdateDTO dto);
        void RandevuDoktorGuncelle(int randevuId,RandevuDoktorUpdateDTO dto);
        void RandevuSil(int randevuId);
        IEnumerable<Randevu> OnaylananRandevulariListele();
        IEnumerable<Randevu> ReddedilenRandevulariListele();
        IEnumerable<Randevu> BekleyenRandevulariListele();
        IEnumerable<Randevu> TumRandevulariListele();
        IEnumerable<Randevu> BugunkuRandevulariListele();
    }
}
