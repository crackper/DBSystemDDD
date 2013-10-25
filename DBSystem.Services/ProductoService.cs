using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBSystem.Core;
using DBSystem.Core.Domain;
using DBSystem.Core.Data;
using DBSystem.Data;

namespace DBSystem.Services
{
    public class ProductoService:IProductoService
    {
        IRepository<Producto> _repositoryProducto;

        public List<Producto> GetAllProductos(string productName = "")
        {
            var context = new IkaroContext("DBSystemContext");
            _repositoryProducto = new EfRepository<Producto>(context);

           

            /*var query = _repositoryProducto.Get(predicate:p=>p.Descripcion.ToUpper().Contains(productName.ToUpper()), 
                                    orderBy: null, 
                                    includeProperties:"");*/

            var query = _repositoryProducto.Table;

            if (productName !="")
            {
                query = query.Where(p => p.Descripcion.ToUpper().Contains(productName.ToUpper()));
            }

            _repositoryProducto.Expand(query, "Categoria");

            return query.ToList();
        }
    }
}
