using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DBSystem.Web.Models
{
    public class ProductoModel
    {
        public ProductoModel()
        {
            CategoriasDiponibles = new List<SelectListItem>();
        }

        public Int32 Id { get; set; }
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public Int32 CategoriaId { get; set; }
        public decimal Precio { get; set; }
        public decimal Stock { get; set; }
        public bool Descontinuado { get; set; }

        public IList<SelectListItem> CategoriasDiponibles { get; set; }
    }
}