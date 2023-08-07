using Oson.Domain.Commons;

namespace Oson.Data.IRepository;

public interface IGenericRepository<T> where T : Auditable
{
    Task<T> Create(T entity);
    Task<T> Update(T entity);
    Task<bool> Delete(long Id);
    Task<IQueryable<T>> GetAll();
    Task<T> GetbyId(long Id);
}
