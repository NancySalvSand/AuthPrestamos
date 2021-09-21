using AuthPrestamos.Areas.Identity.Data;
using AuthPrestamos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthPrestamos.Data
{
    public class APrestamosContext : IdentityDbContext<ApplicationUser>
    {
        public APrestamosContext(DbContextOptions<APrestamosContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);



        }




        public DbSet<Prestamo> Prestamo { get; set; }
        public DbSet<Abono> Abono { get; set; }

    }



}

