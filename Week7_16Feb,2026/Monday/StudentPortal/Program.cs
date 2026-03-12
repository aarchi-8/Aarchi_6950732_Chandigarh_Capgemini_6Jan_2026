using Microsoft.EntityFrameworkCore;
using StudentPortal.Models;
using StudentPortal.Services;

namespace StudentPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<StudentDBContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDB")));

            builder.Services.AddSingleton<IRequestLogService, RequestLogService>();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.UseMiddleware<RequestTrackingMiddleware>();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Student}/{action=Index}/{id?}");

            app.Run();
        }
    }
}