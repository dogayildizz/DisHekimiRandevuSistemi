using DisHekimiRandevuSistemi.BLL.Services.CRUDQueries;
using DisHekimiRandevuSistemi.BLL.Services.Interfaces;
using DisHekimiRandevuSistemi.BLL.Services.Ýnterfaces;
using DisHekimiRandevuSistemi.DAL.Context;
using DisHekimiRandevuSistemi.DAL.Repositories.Implementations;
using DisHekimiRandevuSistemi.DAL.Repositories.Interfaces;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace DisHekimiRandevuYonetimSistemi.UI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //MyDbContext’i DI sistemine SQL Server’a baðlanacak þekilde ekler. Connection string’i config’den çeker ve baðlanmaya hazýr hale getirir.
            builder.Services.AddDbContext<MyDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("defaultconnection")));

            builder.Services.AddScoped(typeof(IHizmetRepository<>),typeof(HizmetRepository<>));
            builder.Services.AddScoped(typeof(IKullaniciRepository<>),typeof(KullaniciRepository<>));
            builder.Services.AddScoped(typeof(IRandevuRepository<>),typeof(RandevuRepository<>));

            builder.Services.AddScoped(typeof(IHizmetService), typeof(HizmetService));
            builder.Services.AddScoped(typeof(IKullaniciService), typeof(KullaniciService));
            builder.Services.AddScoped(typeof(IRandevuService), typeof(RandevuService));

            builder.Services.AddSession();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
