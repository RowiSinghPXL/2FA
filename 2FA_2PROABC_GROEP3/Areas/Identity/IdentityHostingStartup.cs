using System;
using _2FA_2PROABC_GROEP3.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(_2FA_2PROABC_GROEP3.Areas.Identity.IdentityHostingStartup))]
namespace _2FA_2PROABC_GROEP3.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<_2FA_2PROABC_GROEP3Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("_2FA_2PROABC_GROEP3ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<_2FA_2PROABC_GROEP3Context>();
            });
        }
    }
}