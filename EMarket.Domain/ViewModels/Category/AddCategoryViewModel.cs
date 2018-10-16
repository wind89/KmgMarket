using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EMarket.Domain.ViewModels.Category
{
    public class AddCategoryViewModel
    {
        public Guid? Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<string> Properties { get; set; }
    }
}
