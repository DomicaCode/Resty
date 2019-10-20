using System;

namespace Resty.Model.Common.Models
{
    public interface IOrder : IBaseModel
    {
        #region Properties

        string Address { get; set; }
        string Email { get; set; }
        uint FloorNumber { get; set; }
        Guid FoodItemId { get; set; }
        string FullName { get; set; }
        string PhoneNumber { get; set; }

        #endregion Properties
    }
}