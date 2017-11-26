using ShopApp.Data.Entities;
using ShopApp.Infrastructure.Interfaces;

namespace ShopApp.Data.IRepositories
{
    public interface IPermissionRepository : IRepository<Permission, int>
    {
    }
}