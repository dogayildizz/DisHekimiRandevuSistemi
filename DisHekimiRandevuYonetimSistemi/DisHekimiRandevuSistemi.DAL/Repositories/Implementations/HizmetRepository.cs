using DisHekimiRandevuSistemi.DAL.Context;
using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Repositories.Implementations
{
    public class HizmetRepository<T> : IHizmetRepository<T> where T : BaseEntity
    {
        private readonly MyDbContext _context;

        public HizmetRepository(MyDbContext context)
        {
            _context = context;
        }

        public T GetirById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> HepsiniGetir()
        {
            return _context.Set<T>().ToList();
        }
    }
}
