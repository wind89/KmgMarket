using System;
using System.Collections.Generic;
using System.Text;

namespace EMarket.Domain.ViewModels.Product
{
    public class SearchQueryParameterModel
    {
        public Guid CategoryPropertyId { get; set; }

        public string Query { get; set; }
    }
}
