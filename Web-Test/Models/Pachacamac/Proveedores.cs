using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Proveedores
    {
        public Proveedores()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string CargoContacto { get; set; }
        public string Direc { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Cpostal { get; set; }
        public string Pais { get; set; }
        public string Te { get; set; }
        public string Fax { get; set; }
        public string PagPrincipal { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
