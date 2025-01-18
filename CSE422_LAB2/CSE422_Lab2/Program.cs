using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CSE422_Lab2.Data;
using System.Configuration;
namespace CSE422_Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("CSE422_Lab2Context");
            var serverVersion = ServerVersion.AutoDetect(connectionString);
            
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<CSE422_Lab2Context>(
                DbContextOptions => DbContextOptions.UseMySql(connectionString, serverVersion));
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
                pattern: "{controller=Categories}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
