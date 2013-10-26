using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBSystem.Core;
using DBSystem.Core.Domain;

namespace DBSystem.Services
{
    public interface IProductoService
    {
        List<Producto> GetAllProductos(string productName = "");
        Producto GetProductoById(Int32 Id);
        void UpdateProducto(Producto producto);
    }
}
