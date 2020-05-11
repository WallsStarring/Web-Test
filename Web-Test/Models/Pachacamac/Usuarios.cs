using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Usuarios
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string NombreyApellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }
        public string Email { get; set; }
        public byte Intentos { get; set; }
        public bool Bloqueado { get; set; }
    }
}
