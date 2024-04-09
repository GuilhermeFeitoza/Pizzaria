using WebAPI.Models;
namespace WebAPI.Repositories
{
    public class FuncionarioRepository : GenericRepository<TbFuncionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(dbContext repositoryContext)
             : base(repositoryContext)
        {
        }
    }
}