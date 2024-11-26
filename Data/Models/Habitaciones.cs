using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Models
{
    public class Habitaciones
    {
        [Key]
        public int IdHabitacion { get; set; }

        public string Descripcion { get; set; }

        public int Precio { get; set; }

        public bool Disponible { get; set; }

        // propiedades de navegacion
        public List<Reservaciones> Reservaciones { get; set; }
    }
}
