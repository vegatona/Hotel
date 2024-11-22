﻿using System.ComponentModel.DataAnnotations;

namespace Hotel.Data.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CURP { get; set; }
        public int Precio { get; set; }
    }
}