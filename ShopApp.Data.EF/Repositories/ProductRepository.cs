using ShopApp.Data.Entities;
using ShopApp.Data.IRepositories;

namespace ShopApp.Data.EF.Repositories
{
    public class ProductRepository : EFRepository<Product, int>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}