using AutoMapper;
using ShopApp.Application.ViewModels.Product;
using ShopApp.Application.ViewModels.System;
using ShopApp.Data.Entities;

namespace ShopApp.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Function, FunctionViewModel>();
        }
    }
}