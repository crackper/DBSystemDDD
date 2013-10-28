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
                        return new ProductoViewModel() 
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

            var model = new ProductoListModel() 
            {
                Criterio = "",
                Productos = lista
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(ProductoListModel model)
        {
            var lista = _productoService.GetAllProductos( model.Criterio)
                .Select(p =>
                {
                    return new ProductoViewModel()
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
           
            model.Productos = lista;

            return View(model);
        }

        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            var lista = _productoService.GetAllProductos("").AsEnumerable();
            return Json(lista);
        }

        public ActionResult Edit(Int32 id)
        {
            var producto = _productoService.GetProductoById(id);
            var categorias = _catgoriaService.GetGategoriasByCriterio("");

            var productoModel = new ProductoModel() 
            {
                Id= producto.Id,
                CategoriaId = producto.CategoriaId,
                Codigo = producto.Codigo,
                Descripcion = producto.Descripcion,
                Precio = producto.Precio,
                Stock = producto.Stock,
                Descontinuado = producto.Descontinuado,
            };

            categorias.Each(c => productoModel.CategoriasDiponibles.Add(
                            new SelectListItem() 
                            { 
                                Text = c.descripcion, 
                                Value = c.Id.ToString()
                            }));

            return View(productoModel);
        }

        [HttpPost]
        public ActionResult Edit(Producto producto)
        {
            _productoService.UpdateProducto(producto);

            return RedirectToAction("index");
        }

    }
}
