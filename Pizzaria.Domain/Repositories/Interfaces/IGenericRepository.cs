using System.Linq.Expressions;

namespace Pizzaria.Domain.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Insert(T obj);
        Task Update(T obj);
        Task Delete(int id);
        IQueryable<T> Query();
    }
}