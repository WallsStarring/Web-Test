using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Pedidos
    {
        public Pedidos()
        {
            DetPeds = new HashSet<DetPeds>();
        }

        public int Id { get; set; }
        public int? IdClientes { get; set; }
        public int? IdEmpleados { get; set; }
        public DateTime? FechaPed { get; set; }
        public DateTime? FechaEntr { get; set; }
        public DateTime? FechaEnv { get; set; }
        public int? IdTransportes { get; set; }
        public decimal? Cargo { get; set; }
        public string Destinatario { get; set; }
        public string DirDestinatario { get; set; }
        public string CiudadDest { get; set; }
        public string RegDestinatario { get; set; }
        public string CpostalDes { get; set; }
        public int? IdPaises { get; set; }

        public virtual Clientes IdClientesNavigation { get; set; }
        public virtual Empleados IdEmpleadosNavigation { get; set; }
        public virtual Paises IdPaisesNavigation { get; set; }
        public virtual Transportes IdTransportesNavigation { get; set; }
        public virtual ICollection<DetPeds> DetPeds { get; set; }
    }
}
