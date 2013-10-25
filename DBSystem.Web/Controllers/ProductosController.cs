using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBSystem.Core.Domain;
using DBSystem.Services;

namespace DBSystem.Web.Controllers
{
    public class ProductosController : Controller
    {
        IProductoService _productoService;

        public ProductosController()
        {
            _productoService = new ProductoService();
        }

        //
        // GET: /Productos/

        public ActionResult Index()
        {
            var lista = _productoService.GetAllProductos("");
            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio="")
        {
            var lista = _productoService.GetAllProductos(criterio);
            return View(lista);
        }

    }
}
