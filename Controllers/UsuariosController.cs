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

        [HttpPost("agregar usuarios")]
        public IActionResult AddUsuario([FromBody]UsuarioVM usuario)
        {
            _usuariosServices.AddUsuario(usuario);
            return Ok();
        }
    }
}
