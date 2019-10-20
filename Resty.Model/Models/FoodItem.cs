using Resty.Model.Common.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resty.Model.Models
{
    [Table("FoodItem")]
    public class FoodItem : BaseModel, IFoodItem
    {
        #region Properties

        public string Description { get; set; } = null!;

        [ForeignKey("FoodItemCategoryId")]
        public FoodItemCategory FoodItemCategory { get; set; } = null!;

        public Guid FoodItemCategoryId { get; set; }
        public string Ingredients { get; set; } = null!;
        public bool IsEnabled { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }

        public int SortOrder { get; set; }

        #endregion Properties
    }
}