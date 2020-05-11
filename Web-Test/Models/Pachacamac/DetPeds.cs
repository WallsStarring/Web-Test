using System;
using System.Collections.Generic;

namespace Web_Test.Models.Pachacamac
{
    public partial class DetPeds
    {
        public int Id { get; set; }
        public int? IdPedidos { get; set; }
        public int IdProductos { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }

        public virtual Pedidos IdPedidosNavigation { get; set; }
        public virtual Productos IdProductosNavigation { get; set; }
    }
}
