using Resty.Model.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resty.Model.Models
{
    [Table("FoodItem")]
    public class FoodItem : BaseModel, IFoodItem
    {
        #region Properties
        public string Description { get; set; } = null!;
        public string Ingredients { get; set; } = null!;
        public decimal Price { get; set; }

        #endregion Properties
    }
}