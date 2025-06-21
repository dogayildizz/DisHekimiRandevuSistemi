using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.DTOs
{
    public record RandevuCreateDTO
    {
        public int HizmetId { get; set; } //Burada sadece Hizmetin benzersiz kimliği (ID) taşınır. Çünkü DTO’nun görevi veri taşımak, ilişkili nesnenin tüm detaylarını taşımak değil.

        public DateTime RandevuTarihi { get; set; }
    }
}
