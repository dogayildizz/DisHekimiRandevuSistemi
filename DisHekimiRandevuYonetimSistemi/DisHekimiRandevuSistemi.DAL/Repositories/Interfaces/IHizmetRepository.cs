using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Repositories.Interfaces
{
    public interface IHizmetRepository<T> : IOku<T> where T : BaseEntity
    {
    }
}
