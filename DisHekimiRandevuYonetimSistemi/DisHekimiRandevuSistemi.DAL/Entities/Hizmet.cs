using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Entities
{
    public class Hizmet : BaseEntity
    {
        public string HizmetAdi { get; set; }
        public ICollection<Randevu> Randevular { get; set; }

    }
}
