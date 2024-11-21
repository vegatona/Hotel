using Hotel.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Hotel.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Habitacion> Habitaciones { get; set; }
    }
}
