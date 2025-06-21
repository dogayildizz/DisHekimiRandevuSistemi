using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Interfaces
{
    public interface IEkle<T>
    {
        void Ekle(T entity);

        //Not : interface içindeki üyelerin erişim belirteci yazılmaz
    }
}
