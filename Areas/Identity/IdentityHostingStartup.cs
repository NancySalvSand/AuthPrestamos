using AuthPrestamos.Areas.Identity.Data;
using AuthPrestamos.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(AuthPrestamos.Areas.Identity.IdentityHostingStartup))]
namespace AuthPrestamos.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {


            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<APrestamosContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("APrestamosContextConnection")));
                /// cambio de..... modelo 
                services.AddDefaultIdentity<ApplicationUser>(options =>
                options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<APrestamosContext>();
            });
        }
    }
}