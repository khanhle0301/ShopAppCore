using ShopApp.Data.Entities;
using ShopApp.Infrastructure.Interfaces;

namespace ShopApp.Data.IRepositories
{
    public interface ITagRepository : IRepository<Tag, string>
    {
    }
}