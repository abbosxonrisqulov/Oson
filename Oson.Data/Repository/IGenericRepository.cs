namespace Oson.Data.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Create(T entity);
        Task<bool> Delete(T entity);
        Task<IQueryable<T>> GetAll();
        Task<T> GetbyI(long Id);
        Task<T> Update(T entity);
    }
}