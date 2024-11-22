using Hotel.Data.Services;
using Hotel.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        public UsuariosServices _usuariosServices;

        public UsuariosController(UsuariosServices usuariosServices)
        {
            _usuariosServices = usuariosServices;
        }

        //Listar
        [HttpGet("Lista de usuarios")]
        public IActionResult GetAllUsuarios()
        {
            var allusuarios = _usuariosServices.GetAllBks();
            return Ok(allusuarios);
        }
        //Buscar
        [HttpGet("get-usuario-by-id/{id}")]
        public IActionResult GetusuarioById(int id)
        {
            var usuario = _usuariosServices.GetUsuarioById(id);
            return Ok(usuario);
        }

        //agregar
        [HttpPost("agregar usuarios")]
        public IActionResult AddUsuario([FromBody]UsuarioVM usuario)
        {
            _usuariosServices.AddUsuario(usuario);
            return Ok();
        }
    }
}
