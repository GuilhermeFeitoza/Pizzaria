using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{

    public class AvaliacaoRepository : GenericRepository<TbAvaliacao>, IAvaliacaoRepository
    {
        public AvaliacaoRepository(dbContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}