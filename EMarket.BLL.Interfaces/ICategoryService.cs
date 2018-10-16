using EMarket.Domain.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.BLL.Interfaces
{
    public interface ICategoryService
    {
        Task<Guid> Add(AddCategoryViewModel model);

        Task<List<CategoryViewModel>> Get();

        Task<List<CategoryProperyViewModel>> GetProperties(Guid id);

        Task<Guid> Delete(Guid id);
    }
}
