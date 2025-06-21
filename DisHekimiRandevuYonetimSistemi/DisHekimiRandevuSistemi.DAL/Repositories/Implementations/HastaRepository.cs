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
    //where T : BaseEntity diyerek T tipi için bir kısıtlama (constraint) koyuyoruz. Diyoruz ki T mutlaka BaseEntity'den türemiş bir sınıf olmalı.
    public class HastaRepository<T> : IHastaRepository<T> where T : BaseEntity
    {
        private readonly MyDbContext _context;

        public HastaRepository(MyDbContext context)
        {
            _context = context;
        }

        public void Ekle(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public T GetirById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Guncelle(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> HepsiniGetir()
        {
            return _context.Set<T>().ToList();
        }

        public void Sil(int id)
        {
            var entity = _context.Set<T>().Find(id);
            if (entity != null)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
