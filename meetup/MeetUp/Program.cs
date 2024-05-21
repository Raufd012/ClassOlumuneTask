using MeetUp.DAL;
using Microsoft.EntityFrameworkCore;

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AddDbContext>(opt =>
            opt.UseSqlServer(builder.Configuration.GetConnectionString("default")));
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
                );


            app.MapControllerRoute(
                  name: "default",
                  pattern: "{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
       