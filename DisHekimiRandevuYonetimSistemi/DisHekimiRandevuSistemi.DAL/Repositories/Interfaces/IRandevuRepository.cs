using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Repositories.Interfaces
{
    public interface IRandevuRepository<T> : IEkle<T>, ISil<T>, IGuncelle<T>, IOku<T> where T : BaseEntity
    {
    }
}
