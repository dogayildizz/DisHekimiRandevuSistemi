using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Interfaces
{
    public interface IGuncelle<T>
    {
        void Guncelle(T entity);
    }
}
