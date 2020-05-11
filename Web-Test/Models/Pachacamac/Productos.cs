using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class Productos
    {
        public Productos()
        {
            DetPeds = new HashSet<DetPeds>();
        }

        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public int? IdProveedores { get; set; }
        public int? IdCategorías { get; set; }
        public string CantidadPorUnidad { get; set; }
        public decimal? PrecioUnidad { get; set; }
        public short? UnidadesEnExistencia { get; set; }
        public short? UnidadesEnPedido { get; set; }
        public int? NivelNuevoPedido { get; set; }
        public bool Suspendido { get; set; }

        public virtual Categorias IdCategoríasNavigation { get; set; }
        public virtual Proveedores IdProveedoresNavigation { get; set; }
        public virtual ICollection<DetPeds> DetPeds { get; set; }
    }
}
