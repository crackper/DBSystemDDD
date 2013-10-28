using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DBSystem.Core.Domain;
using DBSystem.Services;
using Kendo.Mvc.UI;
using DBSystem.Web.Models;


namespace DBSystem.Web.Controllers
{
    public class ProductosController : Controller
    {
        IProductoService _productoService;
        ICategoriaServie _catgoriaService;

        public ProductosController(IProductoService productoService, ICategoriaServie categoriaService)
        {
            _productoService = productoService;
            _catgoriaService = categoriaService;
        }

        //
        // GET: /Productos/

        public ActionResult Index()
        {
            var lista = _productoService.GetAllProductos("")
                .Select(p => 
                    { 
                        return new ProductoModel() 
                        {
                            Id=p.Id,
                            Codigo = p.Codigo,
                            Descripcion = p.Descripcion,
                            Categoria = _catgoriaService.GetGategoriaById(p.CategoriaId).descripcion,
                            Stock = p.Stock,
                            Precio = p.Precio,
                            Descontinuado = p.Descontinuado
                        }; 
                    }).ToList();

            return View(lista);
        }

        [HttpPost]
        public ActionResult Index(string criterio="")
        {
            var lista = _productoService.GetAllProductos(criterio)
                .Select(p =>
                {
                    return new ProductoModel()
                    {
                        Id = p.Id,
                        Codigo = p.Codigo,
                        Descripcion = p.Descripcion,
                        Categoria = _catgoriaService.GetGategoriaById(p.CategoriaId).descripcion,
                        Stock = p.Stock,
                        Precio = p.Precio,
                        Descontinuado = p.Descontinuado
                    };
                }).ToList();

            return View(lista);
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            var lista = _productoService.GetAllProductos("").AsEnumerable();
            return Json(lista);
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
