using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBSystem.Core.Domain;

namespace DBSystem.Services
{
    public interface ICategoriaServie
    {
        IQueryable<Categoria> GetGategoriasByCriterio(string criterio);
        Categoria GetGategoriaById(Int32 categoriaId);
        void AddCategoria(Categoria categoria);
        void UpdateCategoria(Categoria categoria);
        void RemoveCategoria(Int32 id);
    }
}
