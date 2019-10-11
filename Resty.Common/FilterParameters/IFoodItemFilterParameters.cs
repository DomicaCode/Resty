using System;

namespace Resty.Common.FilterParameters
{
    public interface IFoodItemFilterParameters
    {
        Guid? Id { get; set; }
        string Name { get; set; }
        decimal? Price { get; set; }
    }
}