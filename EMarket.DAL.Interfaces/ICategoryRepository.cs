using EMarket.Domain.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.DAL.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Guid> Add(AddCategoryViewModel model);

        Task<List<CategoryViewModel>> Get();

        Task<List<CategoryProperyViewModel>> GetProperties(Guid id);

        Task<Guid> Delete(Guid id);
    }
}
