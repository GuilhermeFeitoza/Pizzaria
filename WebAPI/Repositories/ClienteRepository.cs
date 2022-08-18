using WebAPI.Models;
namespace WebAPI.Repositories
{
    public class ClienteRepository : GenericRepository<TbCliente>, IClienteRepository
    {
        public ClienteRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}