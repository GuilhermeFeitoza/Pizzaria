using Pizzaria.Domain.Models;
namespace Pizzaria.Domain.Repositories
{
    public class FuncionarioRepository : GenericRepository<TbFuncionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}