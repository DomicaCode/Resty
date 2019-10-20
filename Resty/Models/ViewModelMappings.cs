using AutoMapper;
using Resty.Model.Common.Models;
using Resty.Model.Models;
using Resty.Web.Models.Food;

namespace Resty.Web.Models
{
    public class ViewModelMappings : Profile
    {
        #region Constructors

        public ViewModelMappings()
        {
            CreateMap<IFoodItem, FoodItemViewModel>().ReverseMap();
            CreateMap<FoodItem, FoodItemViewModel>().ReverseMap();

            CreateMap<IFoodItemCategory, FoodItemCategoryViewModel>().ReverseMap();
            CreateMap<FoodItemCategory, FoodItemCategoryViewModel>().ReverseMap();

            CreateMap<IOrder, OrderViewModel>().ReverseMap();
            CreateMap<Order, OrderViewModel>().ReverseMap();
        }

        #endregion Constructors
    }
}