using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Hotel.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Habitaciones> Habitaciones { get; set; }
    }
}
