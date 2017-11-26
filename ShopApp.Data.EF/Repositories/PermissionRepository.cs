using ShopApp.Data.Entities;
using ShopApp.Data.IRepositories;

namespace ShopApp.Data.EF.Repositories
{
    public class PermissionRepository : EFRepository<Permission, int>, IPermissionRepository
    {
        public PermissionRepository(AppDbContext context) : base(context)
        {
        }
    }
}