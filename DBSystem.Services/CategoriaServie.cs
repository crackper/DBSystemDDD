using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBSystem.Core;
using DBSystem.Core.Domain;
using DBSystem.Data;
using DBSystem.Core.Data;

namespace DBSystem.Services
{
    public class CategoriaServie:ICategoriaServie
    {
        IUnitOfWork _uow;
        IRepository<Categoria> _categoriaRepository;

        public CategoriaServie(IUnitOfWork uow)
        {
            _uow = uow;
            _categoriaRepository = _uow.GetRepository<Categoria>();
        }

        public IQueryable<Categoria> GetGategoriasByCriterio(string criterio)
        {
            var query =  _categoriaRepository.Table;

            if (criterio != "" && criterio != null)
                query = query.Where(c => c.descripcion.ToUpper().Contains(criterio.ToUpper()));

            return query;
        }

        public Categoria GetGategoriaById(int categoriaId)
        {
            return _categoriaRepository.GetById(categoriaId);
        }

        public void AddCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public void RemoveCategoria(int id)
        {
            throw new NotImplementedException();
        }
    }
}
