using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Interfaces;

public interface IContext<TContext> where TContext : DbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
    Task<int> SaveChangesAsync();
}
