using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Transportes
    {
        public Transportes()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Te { get; set; }

        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
