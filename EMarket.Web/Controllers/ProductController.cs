using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMarket.BLL.Interfaces;
using EMarket.Domain.ViewModels.Product;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMarket.Web.Controllers
{
    public class ProductController : BaseController<IProductService>
    {
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService service, ICategoryService categoryService) : base(service)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.Get();
            return View(categories);
        }

        [HttpPost]
        public async Task<JsonResult> Search(SearchQueryModel query)
        {
            return Json(await Service.Get(query));
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddProductViewModel()
            {
                Categories = await _categoryService.Get()
            };

            return View(model); 
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = await Service.Add(model);
            }
            model.Categories = await _categoryService.Get();
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(Guid id)
        {
            return View(await Service.Get(id));
        }
    }
}
