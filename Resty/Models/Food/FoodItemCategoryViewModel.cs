using Resty.Web.Models.Generic;
using System.ComponentModel.DataAnnotations;

namespace Resty.Web.Models.Food
{
    public class FoodItemCategoryViewModel : BaseViewModel
    {
        #region Properties

        [Required]
        public bool IsEnabled { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public int SortOrder { get; set; }

        #endregion Properties
    }
}