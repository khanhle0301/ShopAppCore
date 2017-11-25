using ShopApp.Application.ViewModels.Product;
using ShopApp.Utilities.Dtos;
using System;
using System.Collections.Generic;

namespace ShopApp.Application.Interfaces
{
    public interface IProductService : IDisposable
    {
        List<ProductViewModel> GetAll();
        PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize);
        ProductViewModel Add(ProductViewModel product);
        void Update(ProductViewModel product);
        void Delete(int id);
        ProductViewModel GetById(int id);
        void Save();
    }
}