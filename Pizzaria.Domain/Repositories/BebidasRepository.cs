using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{

   public class BebidasRepository: GenericRepository<TbBebida>, IBebidasRepository
   {
        public BebidasRepository(dbContext repositoryContext) : base(repositoryContext)
        {

        }
   }
}