using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Enums
{
    public enum RolEnum
    {
        Doktor = 1,
        Sekreter, //Yalnızca randevuları görüntüleyebilir (doktoru ve hastaları bilgilendirmek için).
        Hasta,
        Admin //Her şeyin CRUD'unu yapabilir.
    }
}
