using EMarket.Domain.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EMarket.BLL.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewModel>> Get(SearchQueryModel query);

        Task<Guid> Add(AddProductViewModel model);

        Task<ProductViewModel> Get(Guid id);
    }
}
