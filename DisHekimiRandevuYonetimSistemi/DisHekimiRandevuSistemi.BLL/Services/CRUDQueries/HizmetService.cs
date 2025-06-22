using DisHekimiRandevuSistemi.BLL.Services.Interfaces;
using DisHekimiRandevuSistemi.DAL.Entities;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.BLL.Services.CRUDQueries
{
    public class HizmetService : IHizmetService
    {
        private readonly IHizmetRepository<Hizmet> _repo;

        public HizmetService(IHizmetRepository<Hizmet> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Hizmet> TumHizmetleriGetir()
        {
            return _repo.HepsiniGetir();
        }
    }
}
