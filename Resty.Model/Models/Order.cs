using Resty.Model.Common.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Resty.Model.Models
{
    public class Order : BaseModel, IOrder
    {
        #region Properties

        public string Address { get; set; } = null!;

        public string Email { get; set; } = null!;

        public uint FloorNumber { get; set; }

        [ForeignKey("FoodItemId")]
        public virtual FoodItem FoodItem { get; set; } = null!;

        public Guid FoodItemId { get; set; }
        public string FullName { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        #endregion Properties
    }
}