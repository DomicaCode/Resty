using AutoMapper;
using Resty.Model.Common.Models;
using Resty.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
