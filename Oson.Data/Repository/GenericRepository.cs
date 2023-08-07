using Microsoft.EntityFrameworkCore;
using Oson.Data.DbContexts;
using Oson.Data.IRepository;

namespace Oson.Data.Repository;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly AppDbContext appDbContext;
    private readonly DbSet<T> dbSet;

    public GenericRepository()
    {
        appDbContext = new AppDbContext();
        dbSet = appDbContext.Set<T>();
    }

    public async Task<T> Create(T entity)
    {
        return dbSet.Add(entity).Entity;
    }

    public async Task<bool> Delete(T entity)
    {
        var removedEntity = dbSet.Remove(entity);
        return removedEntity.Entity != null;
    }

    public async Task<IQueryable<T>> GetAll()
    {
        return dbSet;
    }

    public async Task<T> GetbyId(long Id)
    {
        return dbSet.Find(Id);
    }

    public async Task<T> Update(T entity)
    {
        return dbSet.Update(entity).Entity;
    }
}
