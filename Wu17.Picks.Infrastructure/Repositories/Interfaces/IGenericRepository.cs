using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wu17.Picks.Infrastructure.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task Add(TEntity entity);
        Task Delete(Guid id);
        IQueryable<TEntity> Find();
        Task<TEntity> FindById(Guid id);
        Task Update(Guid id, TEntity entity);
    }
}
