using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class ClienteRepository : GenericRepository<TbCliente>, IClienteRepository
    {
        public ClienteRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}