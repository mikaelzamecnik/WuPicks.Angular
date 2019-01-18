using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wu17.Picks.Core;
using Wu17.Picks.Infrastructure.Data;
using Wu17.Picks.Infrastructure.Repositories.Interfaces;

namespace Wu17.Picks.Infrastructure.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Find()
        {
            return _context.Set<TEntity>().AsNoTracking()
                .Where(x => !x.IsDeleted);
        }

        public async Task<TEntity> FindById(Guid id)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .SingleOrDefaultAsync(e => e.Id == id && !e.IsDeleted);
        }

        public async Task Add(TEntity entity)
        {
            entity.DateCreated = DateTime.Now;
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var entity = await FindById(id);
            entity.IsDeleted = true;
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Guid id, TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
