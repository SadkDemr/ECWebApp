using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using ECWebApp.Repository.Concrete.EntityFramework;
using ECWebApp.Repository.Abstract;
using AppContext = ECWebApp.Repository.Concrete.EntityFramework.AppContext;
using ECWebApp.IdentityCore;
using Microsoft.AspNetCore.Identity;

namespace ECWebApp
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<ApplicationIdentityDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationIdentityDbContext>()
                .AddDefaultTokenProviders();

            services.AddTransient<IProductRepository, EfProductRepository>();
            services.AddTransient<ICategoryRepository, EfCategoryRepository>();
            services.AddTransient<IUnitOfWork, EfUnitOfWork>();
            services.AddMvc()
                .AddSessionStateTempDataProvider();
            services.AddSession();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseStatusCodePages();
            app.UseSession();
            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
            routes.MapRoute(
               name: "products",
               template: "products/{category?}",
               defaults: new { controller = "Products", action = "List" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Home}/{id?}");

               
            });

            SeedData.EnsurePopulated(app);
            SeedIdentity.CreateIdentityUsers(app.ApplicationServices, Configuration).Wait();
            
        }
    }
}
