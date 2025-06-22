using DisHekimiRandevuSistemi.BLL.DTOs;
using DisHekimiRandevuSistemi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.Services.İnterfaces
{
    public interface IKullaniciService
    {
        void HastaOlustur(KullaniciCreateDTO dto);
        IEnumerable<Kullanici> HastalariListele();
    }
}
