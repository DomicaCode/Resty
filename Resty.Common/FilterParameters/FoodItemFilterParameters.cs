using System;
using System.Collections.Generic;
using System.Text;

namespace Resty.Common.FilterParameters
{
    public class FoodItemFilterParameters : IFoodItemFilterParameters
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }
    }
}
