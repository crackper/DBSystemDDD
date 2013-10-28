using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBSystem.Web.Models
{
    public class ProductoModel
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