using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using smart_garden.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace smart_garden
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
             services.AddDbContext<ApplicationDbContext>(options =>
             options.UseSqlServer(
                 Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default_1",
                    template: "o-nas",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "default_2",
                    template: "oferta/uslugi-ogrodnicze",
                    defaults: new { controller = "Offer", action = "Offer" });

                routes.MapRoute(
                    name: "default_3",
                    template: "oferta/odsniezanie",
                    defaults: new { controller = "Snow", action = "Snow" });

                routes.MapRoute(
                    name: "default_4",
                    template: "blog",
                    defaults: new { controller = "Blog", action = "Main" });

                routes.MapRoute(
                    name: "default_5",
                    template: "kontakt",
                    defaults: new { controller = "Contact", action = "Contact" });

                routes.MapRoute(
                    name: "default_6",
                    template: "kariera",
                    defaults: new { controller = "Career", action = "Career" });

                routes.MapRoute(
                    name: "default-0",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
