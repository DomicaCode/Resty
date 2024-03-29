﻿using Resty.Web.Models.Generic;
using System.ComponentModel.DataAnnotations;

namespace Resty.Web.Models.Food
{
    public class FoodItemViewModel : BaseViewModel
    {
        #region Properties

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string Ingredients { get; set; } = null!;

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public decimal Price { get; set; }

        #endregion Properties
    }
}