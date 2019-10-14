using Newtonsoft.Json;
using Resty.Web.Models.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace Resty.Web.Models.Food
{
    public class FoodItemViewModel : BaseViewModel
    {
        #region Properties

        [Required]
        public string Description { get; set; } = null!;

        [Required(ErrorMessage = "You need to select a food category!")]
        public Guid? FoodItemCategoryId { get; set; }

        [Required]
        public string Ingredients { get; set; } = null!;

        [Required]
        public bool IsEnabled { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int? SortOrder { get; set; }

        #endregion Properties
    }
}