using System;
using System.Collections.Generic;

#nullable disable

namespace FinalSis457Jras.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Usuario1 { get; set; }
        public string Clave { get; set; }
        public string Rol { get; set; }
        public bool? RegistroActivo { get; set; }
    }
}
