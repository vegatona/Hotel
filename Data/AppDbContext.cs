using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Hotel.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservaciones>()
                .HasOne(a => a.Habitaciones)
                .WithMany(ba => ba.Reservaciones)
                .HasForeignKey(bi => bi.IdHabitaciones);
            
            modelBuilder.Entity<Reservaciones>()
                .HasOne(a => a.Usuario)
                .WithMany(ba => ba.Reservaciones)
                .HasForeignKey(bi => bi.IdUsuario);

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Habitaciones> Habitaciones { get; set; }
        public DbSet<Reservaciones> Reservaciones { get; set; }
    }
}
