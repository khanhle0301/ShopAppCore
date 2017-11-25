using ShopApp.Data.Entities;
using ShopApp.Data.IRepositories;

namespace ShopApp.Data.EF.Repositories
{
    public class ProductTagRepository : EFRepository<ProductTag, int>, IProductTagRepository
    {
        public ProductTagRepository(AppDbContext context) : base(context)
        {
        }
    }
}