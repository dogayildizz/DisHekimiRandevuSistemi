using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
    }
}
