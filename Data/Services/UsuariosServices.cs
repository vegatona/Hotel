using Hotel.Data.Models;
using Hotel.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hotel.Data.Services
{
    public class UsuariosServices
    {
        private AppDbContext _context;
        public UsuariosServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddUsuario(UsuarioVM usuario)
        {
            var _usuario = new Usuario()
            {
                Nombre = usuario.Nombre,
                Apellido = usuario.Apellido,
                CURP = usuario.CURP,
                NumTel = usuario.NumTel,
            };
            _context.Usuarios.Add(_usuario);
            _context.SaveChanges();
        }

        //LISTAR
        public List<Usuario> GetAllBks() => _context.Usuarios.ToList();
        //buscar
        public Usuario GetUsuarioById(int usuarioid) => _context.Usuarios.FirstOrDefault(n => n.IdUsuario == usuarioid);
    }
}
