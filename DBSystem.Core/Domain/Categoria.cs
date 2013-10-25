using System;
using System.Collections.Generic;

namespace DBSystem.Core.Domain
{
    public partial class Categoria:BaseEntity
    {
        public Categoria()
        {
            this.Productoes = new List<Producto>();
        }

        public string descripcion { get; set; }
        public string comentario { get; set; }
        public virtual ICollection<Producto> Productoes { get; set; }
    }
}
