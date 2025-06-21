using DisHekimiRandevuSistemi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Entities
{
    public class Kullanici : BaseEntity
    {
        public string AdSoyad { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string TelefonNumarasi { get; set; }
        public RolEnum Rol { get; set; }
        public ICollection<Randevu> Randevular { get; set; }

    }
}
