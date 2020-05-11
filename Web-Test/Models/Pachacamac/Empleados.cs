using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Empleados
    {
        public Empleados()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        public int Id { get; set; }
        public string Apellidos { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Tratamiento { get; set; }
        public DateTime? FechaNac { get; set; }
        public DateTime? FechaContrat { get; set; }
        public string Dire { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Cpostal { get; set; }
        public string Pais { get; set; }
        public string TelDomicilio { get; set; }
        public string Exten { get; set; }
        public string Notas { get; set; }
        public int? Jefe { get; set; }

        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
