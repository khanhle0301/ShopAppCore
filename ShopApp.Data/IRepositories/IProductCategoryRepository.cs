using ShopApp.Data.Entities;
using ShopApp.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace ShopApp.Data.IRepositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory, int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}