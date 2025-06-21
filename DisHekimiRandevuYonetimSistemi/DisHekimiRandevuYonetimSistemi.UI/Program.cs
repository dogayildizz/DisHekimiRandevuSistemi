using DisHekimiRandevuSistemi.DAL.Context;
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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
