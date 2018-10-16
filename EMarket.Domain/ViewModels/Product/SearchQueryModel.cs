using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.Domain.ViewModels.Product
{
    public class SearchQueryModel
    {
        public string SearchText { get; set; }

        public Guid? CategoryId { get; set; }

        public Dictionary<Guid, string> Properties { get; set; }
    }
}
