using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBSystem.Web.Models
{
    public class ProductoViewModel
    {
        public int Id { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public String Categoria { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public bool Descontinuado { get; set; }

    }
}
