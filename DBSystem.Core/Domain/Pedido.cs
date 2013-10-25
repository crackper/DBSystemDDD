using System;
using System.Collections.Generic;

namespace DBSystem.Core.Domain
{
    public partial class Pedido:BaseEntity
    {
        public Pedido()
        {
            this.DetallePedidoes = new List<DetallePedido>();
        }

        public int clienteId { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal total { get; set; }
        public int formaPagoId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidoes { get; set; }
        public virtual FormaPago FormaPago { get; set; }
    }
}
