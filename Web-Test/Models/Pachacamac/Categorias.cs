using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Categorias
    {
        public Categorias()
        {
            Productos = new HashSet<Productos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descrip { get; set; }
        public string ArchivoImagen { get; set; }

        public virtual ICollection<Productos> Productos { get; set; }
    }
}
