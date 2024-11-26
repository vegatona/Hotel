using Hotel.Data.Services;
using Hotel.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionesController : ControllerBase
    {
        public HabitacionesServices _habitacionesServices;

        public HabitacionesController(HabitacionesServices habitacionesServices)
        {
            _habitacionesServices = habitacionesServices;
        }
        //
        [HttpGet("lista de habitaciones")]
        public IActionResult GetAllHabitaciones()
        {
            var allhabitaciones = _habitacionesServices.GetAllHabitaciones();
            return Ok(allhabitaciones);

        }
        //
        [HttpGet("Buscar habitaciones/{id}")]
        public IActionResult GetHabitacionesById(int id)
        {
            var habitaciones = _habitacionesServices.GetHabitacionesById(id);
            return Ok(habitaciones);

        }
        //
        [HttpPost("agregar habitaciones")]
        public IActionResult AddHabitaciones([FromBody]HabitacionesVM habitaciones)
        {
            _habitacionesServices.AddHabitacion(habitaciones);
            return Ok();

           
        }

        [HttpPut("editar habitaciones/{id}")]
        public IActionResult UpdateHabitacionesById(int id, [FromBody] HabitacionesVM habitaciones)
        {
            var updateHabitaciones = _habitacionesServices.UpdateHabitacionesById(id, habitaciones);

            return Ok(updateHabitaciones);

        }

        [HttpDelete("eliminar habitaciones/{id}")]

        public IActionResult DeleteHabitacionesById(int id) 
        {
            
            _habitacionesServices.DeleteHabitacionesById(id);
            return Ok();

        }
    }
}
