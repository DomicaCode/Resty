using AutoMapper;
using Resty.Model.Common.Models;
using Resty.Model.Models;

namespace Resty.Model
{
    public class ModelMappings : Profile
    {
        public ModelMappings()
        {
            CreateMap<IFoodItem, FoodItem>().ReverseMap();
        }
    }
}
