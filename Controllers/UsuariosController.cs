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
        [HttpGet("Buscar Usuario")]
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

        //editar
        [HttpPut("Editar usuario")]
        public IActionResult UpdateUsuarioById(int id, [FromBody]UsuarioVM usuario)
        {
            var updateUsuario = _usuariosServices.UpdateUsuarioById(id, usuario);
            return Ok(updateUsuario);
        }

        //eliminar
        [HttpDelete("Eliminar Usuario")]
        public IActionResult DeleteUsuarioById(int id)
        {
            _usuariosServices.DeleteUsuarioById(id);
            return Ok();
        }
    }
}
