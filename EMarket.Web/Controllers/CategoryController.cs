using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EMarket.BLL.Interfaces;
using EMarket.Domain.ViewModels.Category;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EMarket.Web.Controllers
{
    public class CategoryController : BaseController<ICategoryService>
    {
        public CategoryController(ICategoryService service) : base(service)
        {
        }

        public async Task<IActionResult> Index()
        {
            var categories = await Service.Get();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new AddCategoryViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Id = await Service.Add(model);
            }
            return View(model);
        }

        [HttpGet]
        public async Task<JsonResult> Properties(Guid id)
        {
            return Json(await Service.GetProperties(id));
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await Service.Delete(id);
            return await Task.Run(() => RedirectToAction("Index"));
        }
    }
}
