using MyShop.Core;

namespace MyShop.Data;

public interface IRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int id);

    Task<List<T>> GetAllAsync();

    Task InsertAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(T entity);

    IQueryable<T> Table { get; }
}

