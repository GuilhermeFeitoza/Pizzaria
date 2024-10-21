using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class PizzaIngredienteRepository : GenericRepository<TbPizzaIngrediente>, IPizzaIngredientesRepository
    {
        public PizzaIngredienteRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}