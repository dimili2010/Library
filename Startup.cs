using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Library.Data;
using Microsoft.EntityFrameworkCore;
using Library.Repositories;

namespace Library
{
    public class Startup
    {
        private IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ILibraryRepository, LibraryRepository>();

            services.AddDbContext<LibroContext>(options =>
            options.UseSqlite("Data Source=travel.db"));

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, LibroContext libroContext)
        {
            libroContext.Database.EnsureDeleted();
            libroContext.Database.EnsureCreated();

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "LibroRoute",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Libro", action = "Index" },
                    constraints: new { id = "[0-9]+" });
            });
        }
    }
}
