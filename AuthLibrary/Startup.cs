using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthLibrary.Areas.Identity.Data;
using AuthLibrary.Data;
using AuthLibrary.DomainRpository;
using AuthLibrary.Interface;
using AuthLibrary.Models.MemberEntities;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;

namespace AuthLibrary
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AuthLibraryDBContext>(options =>
            //      options.UseSqlServer(
            //          Configuration.GetConnectionString("AuthLibraryDBContextConnection")));

            //services.AddDefaultIdentity<Person>(options => options.SignIn.RequireConfirmedAccount = true)
            //    .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<AuthLibraryDBContext>();
            services.AddScoped<ISubjectRepository, SubjectManager>();
            // services.AddAutoMapper(typeof(Startup));
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllersWithViews();
            services.AddRazorPages();
            //services.AddIdentity<AuthLibraryUser,IdentityRole>(config=>
            //    { config.SignIn.RequireConfirmedEmail = true; }
            //);
            services.AddMailKit(config =>
            {
                config.UseMailKit(Configuration.GetSection("Email").Get<MailKitOptions>());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
