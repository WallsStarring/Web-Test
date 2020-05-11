using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Paises
    {
        public Paises()
        {
            Clientes = new HashSet<Clientes>();
            Pedidos = new HashSet<Pedidos>();
        }

        public int Id { get; set; }
        public string Pais { get; set; }
        public string CodEnTransportes { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
