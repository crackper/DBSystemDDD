using System;
using System.Collections.Generic;

namespace DBSystem.Core.Domain
{
    public partial class Producto:BaseEntity
    {
        public Producto()
        {
            this.DetallePedidoes = new List<DetallePedido>();
        }

        public int CategoriaId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public byte[] Foto { get; set; }
        public bool Descontinuado { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<DetallePedido> DetallePedidoes { get; set; }
    }
}
