using System;
using System.Collections.Generic;

namespace DBSystem.Core.Domain
{
    public partial class FormaPago:BaseEntity
    {
        public FormaPago()
        {
            this.Pedidoes = new List<Pedido>();
        }

        public string descripcion { get; set; }
        public int nroDias { get; set; }
        public virtual ICollection<Pedido> Pedidoes { get; set; }
    }
}
