using System;
using System.Collections.Generic;

namespace DBSystem.Core.Domain
{
    public partial class Cliente:BaseEntity
    {
        public Cliente()
        {
            this.Pedidoes = new List<Pedido>();
        }

        public string rucDni { get; set; }
        public string razonSocial { get; set; }
        public string direccion { get; set; }
        public virtual ICollection<Pedido> Pedidoes { get; set; }
    }
}
