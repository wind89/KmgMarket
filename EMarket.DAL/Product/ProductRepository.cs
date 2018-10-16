using EMarket.DAL.Base;
using EMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using EMarket.Domain.ViewModels.Product;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using EMarket.Domain.ViewModels.Category;

namespace EMarket.DAL.Product
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Guid> Add(AddProductViewModel model)
        {
            var product = new Models.Product()
            {
                Name = model.Name,
                CreatedAt = DateTime.Now,
                CategoryId = model.CategoryId,
                Description = model.Description,
                Price = model.Price
            };
            Context.Products.Add(product);
            await Context.SaveChangesAsync();

            if (model.Properties != null)
            foreach(var propery in model.Properties)
            {
                if (string.IsNullOrWhiteSpace(propery.Value))
                    continue;

                var productProperty = new Models.ProductProperty()
                {
                    ProductId = product.Id,
                    CategoryPropertyId = propery.Key,
                    Value = propery.Value,
                    CreatedAt = DateTime.Now
                };
                Context.ProductProperties.Add(productProperty);
                await Context.SaveChangesAsync();
            }

            return product.Id;
        }

        public async Task<List<ProductViewModel>> Get(SearchQueryModel query)
        {
            var ret = await Context.Products.Include(x => x.Properties)
                .Include(x=>x.Category)
                .Where(x =>
                (x.Name.Contains(query.SearchText) || string.IsNullOrWhiteSpace(query.SearchText))
                && (query.Properties == null || query.Properties.Count(p => !string.IsNullOrWhiteSpace(p.Value)) == 0 || (x.Properties.Any(z => query.Properties.Where(p=>!string.IsNullOrWhiteSpace(p.Value)).Any(p => p.Key == z.CategoryPropertyId && (z.Value == p.Value)))))
                && (x.CategoryId == query.CategoryId || query.CategoryId == null)
                ).Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Description = x.Description,
                    Category = new CategoryViewModel() {
                        Name = x.Category.Name
                    },              
                }).ToListAsync();
            return ret;
        }

        public async Task<ProductViewModel> Get(Guid id)
        {
            return await Context.Products
                .Include(x => x.Properties).ThenInclude(z => z.CategoryProperty)
                .Include(x => x.Category)
                .Where(x => x.Id == id)
                .Select(x => new ProductViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Price = x.Price,
                    Category = new CategoryViewModel()
                    {
                        Name = x.Category.Name
                    },
                    Properties = x.Properties
                    .Select(z => new ProductPropertyViewModel()
                    {
                        Name = z.CategoryProperty.Name,
                        Value = z.Value
                    }).ToList()
                }).FirstOrDefaultAsync();

        }
    }
}
