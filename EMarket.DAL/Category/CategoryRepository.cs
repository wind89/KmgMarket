using EMarket.DAL.Base;
using EMarket.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using EMarket.Domain.ViewModels.Category;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EMarket.DAL.Category
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Guid> Delete(Guid id)
        {
            var category = Context.Categories.FirstOrDefault(x => x.Id == id);
            Context.Categories.Remove(category);
            await Context.SaveChangesAsync();
            return category.Id;
        }

        public async Task<Guid> Add(AddCategoryViewModel model)
        {
            var category = new Models.Category()
            {
                Name = model.Name,
                CreatedAt = DateTime.Now
            };
            Context.Categories.Add(category);
            await Context.SaveChangesAsync();

            if (model.Properties != null)
            foreach (var property in model.Properties)
            {
                if (string.IsNullOrEmpty(property))
                    continue;

                var categoryProperty = new Models.CategoryProperty()
                {
                    CategoryId = category.Id,
                    CreatedAt = DateTime.Now,
                    Name = property
                };
                Context.CategoryProperties.Add(categoryProperty);
                await Context.SaveChangesAsync();
            }

            return category.Id;
        }

        public async Task<List<CategoryViewModel>> Get()
        {
            return await Context.Categories
                .Select(x => new CategoryViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();
        }

        public async Task<List<CategoryProperyViewModel>> GetProperties(Guid id)
        {
            return await Context.CategoryProperties
                .Where(x => x.CategoryId == id)
                .Select(x => new CategoryProperyViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToListAsync();
        }
    }
}
