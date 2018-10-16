using EMarket.Domain.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMarket.Domain.ViewModels.Product
{
    public class AddProductViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public Dictionary<Guid, string> Properties { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }
}
