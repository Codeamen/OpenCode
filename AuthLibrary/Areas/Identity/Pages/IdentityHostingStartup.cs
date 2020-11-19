using System;
using AuthLibrary.Areas.Identity.Data;
using AuthLibrary.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthLibrary.Areas.Identity.IdentityHostingStartup))]
namespace AuthLibrary.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<AuthLibraryDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthLibraryDBContextConnection")));

                services.AddDefaultIdentity<AuthLibraryUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<AuthLibraryDBContext>();
            });
        }
    }
}