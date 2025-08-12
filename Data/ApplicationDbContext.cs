using Connect4.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Connect4.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Marcador> Marcadores { get; set; }
        public DbSet<PartidaGuardada> PartidasGuardadas { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasOne(u => u.Marcador)
                .WithOne(m => m.ApplicationUser)
                .HasForeignKey<Marcador>(m => m.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
