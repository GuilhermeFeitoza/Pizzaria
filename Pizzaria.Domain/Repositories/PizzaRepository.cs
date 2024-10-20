using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class PizzaRepository : GenericRepository<TbPizza>, IPizzaRepository
    {
        public PizzaRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}