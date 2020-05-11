using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Clientes
    {
        public Clientes()
        {
            Pedidos = new HashSet<Pedidos>();
        }

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public string CargoCont { get; set; }
        public string Dire { get; set; }
        public string Ciudad { get; set; }
        public string Region { get; set; }
        public string Cpostal { get; set; }
        public int? IdPaises { get; set; }
        public string Te { get; set; }
        public string Fax { get; set; }

        public virtual Paises IdPaisesNavigation { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
    }
}
