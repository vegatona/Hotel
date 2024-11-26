using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Models
{
    public class Reservaciones
    {
        [Key]
        public int IdReservaciones { get; set; }
        public int IdHabitaciones { get; set; }

        public Habitaciones Habitaciones { get; set; }
        public int IdUsuario { get; set; }

        public Usuario Usuario { get; set; }

        public int Noches { get; set; }

        //propiedad de navegacion

    }
}
