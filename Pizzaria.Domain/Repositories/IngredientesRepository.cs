using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{

   public class IngredientesRepository: GenericRepository<TbIngrediente>, IIngredientesRepository
   {
        public IngredientesRepository(dbContext repositoryContext) : base(repositoryContext)
        {

        }
   }
}