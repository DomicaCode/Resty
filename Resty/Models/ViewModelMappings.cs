using AutoMapper;
using Resty.Model.Common.Models;
using Resty.Model.Models;
using Resty.Web.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resty.Web.Models
{
    public class ViewModelMappings : Profile
    {
        public ViewModelMappings()
        {
            CreateMap<IFoodItem, FoodItemViewModel>().ReverseMap();
            CreateMap<FoodItem, FoodItemViewModel>().ReverseMap();
        }
    }
}
