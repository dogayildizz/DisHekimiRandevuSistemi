using DisHekimiRandevuSistemi.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiRandevuSistemi.DAL.Context
{
    public class MyDbContext :DbContext
    {
        //DbContext’in çalışması için gerekli olan bağlantı ve yapılandırma ayarlarını alıp, EF Core’a aktarır.
        public MyDbContext (DbContextOptions<MyDbContext> options): base(options) { }
        public DbSet<Hizmet> Hizmetler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Randevu> Randevular { get; set; }
    }
}
