using AutoMapper;
using Resty.Model.Common.Models;
using Resty.Model.Models;

namespace Resty.Model
{
    public class ModelMappings : Profile
    {
        #region Constructors

        public ModelMappings()
        {
            CreateMap<IFoodItem, FoodItem>().ReverseMap();
            CreateMap<FoodItem, FoodItem>().ReverseMap();

            CreateMap<IFoodItemCategory, FoodItemCategory>().ReverseMap();
        }

        #endregion Constructors
    }
}