using ShopApp.Data.Entities;
using ShopApp.Data.IRepositories;

namespace ShopApp.Data.EF.Repositories
{
    public class FunctionRepository : EFRepository<Function, string>, IFunctionRepository
    {
        public FunctionRepository(AppDbContext context) : base(context)
        {
        }
    }
}