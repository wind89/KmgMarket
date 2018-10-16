using EMarket.Domain.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.Domain.ViewModels.Product
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public CategoryViewModel Category { get; set; }

        public List<ProductPropertyViewModel> Properties { get; set; }
    }
}
