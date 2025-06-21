using DisHekimiRandevuSistemi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Entities
{
    public class Randevu : BaseEntity
    {
        public Kullanici Kullanici { get; set; }
        public int KullaniciId { get; set; }
        public Hizmet Hizmet { get; set; }
        public int HizmetId { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public RandevuDurumEnum RandevuDurum { get; set; }
        public DateTime? OnayTarihi { get; set; }

    }
}
