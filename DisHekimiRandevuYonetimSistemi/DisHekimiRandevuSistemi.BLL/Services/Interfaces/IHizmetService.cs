using DisHekimiRandevuSistemi.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.Services.Interfaces
{
    public interface IHizmetService
    {
        IEnumerable<Hizmet> TumHizmetleriGetir();

    }
}
