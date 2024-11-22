using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.ViewModels
{
    public class UsuarioVM
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CURP { get; set; }
        public int NumTel { get; set; }
    }
}
