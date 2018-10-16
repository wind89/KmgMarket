using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.Domain.ViewModels.Category
{
    public class CategoryProperyViewModel
    {
        public Guid Id { get; set; }

        public Guid CategoryId { get; set; }

        public string Name { get; set; }

        public bool Nullable { get; set; }
    }
}
