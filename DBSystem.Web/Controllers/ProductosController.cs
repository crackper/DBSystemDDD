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

        public ActionResult Edit(Int32 id)
        {
            var producto = _productoService.GetProductoById(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            _productoService.UpdateProducto(producto);

            return RedirectToAction("index");
        }

    }
}
