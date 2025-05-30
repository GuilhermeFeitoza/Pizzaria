using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private dbContext context = null;
        public GenericRepository(dbContext _context)
        {
            this.context = _context;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await context.Set<T>().AsNoTracking().ToListAsync();
        }
        public async Task<T> GetById(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }
        public async Task<T> Insert(T obj)
        {
            await context.Set<T>().AddAsync(obj);
            await context.SaveChangesAsync();
            return obj;
        }
        public async Task Update(T obj)
        {
            context.Set<T>().Update(obj);
            await context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var entity = await GetById(id);
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
        }
        public IQueryable<T> Query()
        {
            return context.Set<T>()
                .AsNoTracking();// Opcional, dependendo do uso
        }

    }
}