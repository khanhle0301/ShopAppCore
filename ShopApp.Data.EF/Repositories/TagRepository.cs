using ShopApp.Data.Entities;
using ShopApp.Data.IRepositories;

namespace ShopApp.Data.EF.Repositories
{
    public class TagRepository : EFRepository<Tag, string>, ITagRepository
    {
        public TagRepository(AppDbContext context) : base(context)
        {
        }
    }
}