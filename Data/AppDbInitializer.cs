using Hotel.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Hotel.Data
{
    public class AppDbInitializer
    {
        //metodo para agregar a la BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Usuarios.Any())
                {
                    context.Usuarios.AddRange(new Usuario()
                    {
                        Nombre = "jesus",
                        Apellido = "vega",
                        CURP = "FFF5D4S",
                        NumTel = 644462,
                    },
                    new Usuario()
                    {
                        Nombre = "ricardo",
                        Apellido = "eclud",
                        CURP = "ASDDF55",
                        NumTel = 644450,
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}