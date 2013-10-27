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
        IUnitOfWork _uow;

        public ProductoService(IUnitOfWork uow)
        {
            //var context = new IkaroContext("DBSystemContext");
            //_uow = new UnitOfWork(context);
            _uow = uow;
            _repositoryProducto = _uow.GetRepository<Producto>();
        }

        public List<Producto> GetAllProductos(string productName = "")
        {                   

            var query = _repositoryProducto.Table;

            if (productName !="")
            {
                query = query.Where(p => p.Descripcion.ToUpper().Contains(productName.ToUpper()));
            }

          _repositoryProducto.Include(query, p=>p.Categoria);

            return query.ToList();
        }


        public Producto GetProductoById(int Id)
        {
            return _repositoryProducto.GetById(Id);
        }


        public void UpdateProducto(Producto producto)
        {
            _repositoryProducto.Update(producto);
            _uow.Save();
        }
    }
}
