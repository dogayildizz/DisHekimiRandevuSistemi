using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Interfaces
{
    public interface IOku<T>
    {
        T GetirById(int id); //Tek bir kayıt getirmek için
        IEnumerable<T> HepsiniGetir(); //Tüm kayıtları getirmek için
    }
}
