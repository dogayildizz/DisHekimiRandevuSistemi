using DisHekimiRandevuSistemi.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.DTOs
{
    public record RandevuDoktorUpdateDTO
    {
        public RandevuDurumEnum RandevuDurum { get; set; }
        public DateTime? OnayTarihi { get; set; }
    }
}
