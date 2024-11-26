using Hotel.Data.Models;
using Hotel.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Data.Services
{
    public class HabitacionesServices
    {
        private AppDbContext _context;
        public HabitacionesServices(AppDbContext context)
        {
            _context = context;



        }

        public void AddHabitacion(HabitacionesVM habitaciones)
        {
            var _habitaciones = new Habitaciones()
            {

                Descripcion = habitaciones.Descripcion,
                Precio = habitaciones.Precio,
                Disponible = habitaciones.Disponible,


            };
            _context.Habitaciones.Add(_habitaciones);
            _context.SaveChanges();

        }
        public List<Habitaciones> GetAllHabitaciones() => _context.Habitaciones.ToList();

        public Habitaciones GetHabitacionesById(int habitacionesid) => _context.Habitaciones.FirstOrDefault(n => n.IdHabitacion == habitacionesid);

        public Habitaciones UpdateHabitacionesById(int habitacionesid, HabitacionesVM habitaciones)
        {
            var _habitaciones = _context.Habitaciones.FirstOrDefault(n => n.IdHabitacion == habitacionesid);
            if (_habitaciones != null)
            {
                _habitaciones.Descripcion = habitaciones.Descripcion;
                _habitaciones.Precio = habitaciones.Precio;
                _habitaciones.Disponible = habitaciones.Disponible;

                _context.SaveChanges(); 


            }
            return _habitaciones; 

        }

        public void DeleteHabitacionesById(int habitacionesid)
        {
            var _habitaciones = _context.Habitaciones.FirstOrDefault(n => n.IdHabitacion == habitacionesid);
            if (_habitaciones != null)
            {
                _context.Habitaciones.Remove(_habitaciones);
                _context.SaveChanges();

            }

        }

    }
}
