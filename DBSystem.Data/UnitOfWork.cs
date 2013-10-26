using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBSystem.Core.Data;

namespace DBSystem.Data
{
    public class UnitOfWork:IUnitOfWork
    {
        IDbContext _context;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(IDbContext context)
        {
            _context = context;
            _repositories = new Dictionary<Type, object>();
        }
        
        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : Core.BaseEntity
        {
            if (_repositories.Keys.Contains(typeof(TEntity)))
                return _repositories[typeof(TEntity)] as IRepository<TEntity>;

            var repository = new EfRepository<TEntity>(_context);
            _repositories.Add(typeof(TEntity), repository);
            return repository;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
