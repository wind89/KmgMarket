using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.Domain.ViewModels.Category
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<CategoryProperyViewModel> Properties { get; set; }
    }
}
