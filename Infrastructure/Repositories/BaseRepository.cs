using Infrastructure.Contexts;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Repositories
{
    public abstract class BaseRepo<TEntity>(ApplicationIdentityContext context) where TEntity : class
    {
        private readonly ApplicationIdentityContext _context = context;

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();

                return entity;
            }
            catch { }

            return null!;
        }

        public async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().AnyAsync(predicate);
        }

        public async Task<bool> DeleteAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Remove(entity);
                await _context.SaveChangesAsync();

                return true;
            }
            catch { }

            return false!;
        }

        public virtual async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                var entity = await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);

                return entity ?? null!;
            }
            catch { }

            return null!;
        }   

        public virtual IQueryable<TEntity> GetAll()
        {
            try
            {
                var entities = _context.Set<TEntity>().AsQueryable();
                

                return entities ?? null!;
            }
            catch { }

            return null!;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();

                return entity ?? null!;
            }
            catch { }

            return null!;
        }
    }



}
