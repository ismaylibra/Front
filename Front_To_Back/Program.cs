using Front_To_Back.DAL;
using Microsoft.EntityFrameworkCore;

namespace Front_To_Back
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
           
            var app = builder.Build();
            
            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(endpoints => app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}"));
            
            app.Run();
        }
    }
}