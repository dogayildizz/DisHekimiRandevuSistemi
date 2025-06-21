using DisHekimiRandevuSistemi.DAL.Context;
using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Repositories.Implementations
{
    //where T : BaseEntity diyerek T tipi için bir kısıtlama (constraint) koyuyoruz. Diyoruz ki T mutlaka BaseEntity'den türemiş bir sınıf olmalı.
    public class SekreterRepository<T> : ISekreterRepository<T> where T : BaseEntity
    {
        private readonly MyDbContext _context;

        public SekreterRepository(MyDbContext context)
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
