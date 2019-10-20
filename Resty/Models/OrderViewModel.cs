using System;
using System.ComponentModel.DataAnnotations;

namespace Resty.Web.Models
{
    public class OrderViewModel
    {
        #region Properties

        [Required]
        public string Address { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        [Required]
        public uint FloorNumber { get; set; }

        [Required]
        public Guid FoodItemId { get; set; }

        [Required]
        public string FullName { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;

        #endregion Properties
    }
}