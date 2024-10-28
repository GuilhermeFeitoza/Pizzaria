using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class PedidoRepository : GenericRepository<TbPedido>, IPedidoRepository
    {
        public PedidoRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}