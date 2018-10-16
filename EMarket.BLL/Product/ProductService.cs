using EMarket.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using EMarket.Domain.ViewModels.Product;
using System.Threading.Tasks;
using EMarket.DAL.Interfaces;

namespace EMarket.BLL.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository; 

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Guid> Add(AddProductViewModel model)
        {
            return await _productRepository.Add(model);
        }

        public async Task<List<ProductViewModel>> Get(SearchQueryModel query)
        {
            return await _productRepository.Get(query);
        }

        public async Task<ProductViewModel> Get(Guid id)
        {
            return await _productRepository.Get(id);
        }
    }
}
