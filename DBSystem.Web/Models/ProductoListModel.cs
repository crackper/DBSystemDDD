using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DBSystem.Web.Models
{
    public class ProductoListModel
    {
        public string Criterio { get; set; }
        public List<ProductoViewModel> Productos { get; set; }
    }
}