using System;

namespace Resty.Model.Common.Models
{
    public interface IFoodItem
    {
        string Description { get; set; }
        Guid Id { get; set; }
        string Ingredients { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }
}