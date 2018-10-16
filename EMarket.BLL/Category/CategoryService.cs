using EMarket.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using EMarket.Domain.ViewModels.Category;
using System.Threading.Tasks;
using EMarket.DAL.Interfaces;

namespace EMarket.BLL.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Guid> Add(AddCategoryViewModel model)
        {
            return await _categoryRepository.Add(model);
        }

        public async Task<List<CategoryViewModel>> Get()
        {
            return await _categoryRepository.Get();
        }

        public async Task<List<CategoryProperyViewModel>> GetProperties(Guid id)
        {
            return await _categoryRepository.GetProperties(id);
        }

        public async Task<Guid> Delete(Guid id)
        {
            return await _categoryRepository.Delete(id);
        }
    }
}
