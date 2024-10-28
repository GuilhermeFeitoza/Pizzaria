using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class PedidoProdutoRepository : GenericRepository<TbPedidoProduto>, IPedidoProdutoRepository
    {
        public PedidoProdutoRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}