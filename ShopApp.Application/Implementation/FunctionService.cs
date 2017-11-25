using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ShopApp.Application.Interfaces;
using ShopApp.Application.ViewModels.System;
using ShopApp.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopApp.Application.Implementation
{
    public class FunctionService : IFunctionService
    {
        private IFunctionRepository _functionRepository;

        public FunctionService(IFunctionRepository functionRepository)
        {
            _functionRepository = functionRepository;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Task<List<FunctionViewModel>> GetAll()
        {
            return _functionRepository.FindAll().ProjectTo<FunctionViewModel>().ToListAsync();
        }

        public List<FunctionViewModel> GetAllByPermission(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}