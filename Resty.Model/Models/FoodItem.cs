using Resty.Model.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Resty.Model.Models
{
    [Table("FoodItem")]
    public class FoodItem : IFoodItem
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Ingredients { get; set; }
    }
}
