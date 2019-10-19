using Resty.Model.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resty.Model.Models
{
    [Table("FoodItemCategory")]
    public class FoodItemCategory : BaseModel, IFoodItemCategory
    {
        #region Properties

        public bool IsEnabled { get; set; }
        public int SortOrder { get; set; }

        #endregion Properties
    }
}