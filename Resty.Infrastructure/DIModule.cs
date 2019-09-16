using Autofac;
using Resty.Repository.Common.Repositories;
using Resty.Repository.Repositories;
using Resty.Service.Common.Services;
using Resty.Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resty.Infrastructure
{
    public class DIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Repositories

            builder.RegisterType<FoodItemRepository>().As<IFoodItemRepository>();

            #endregion

            #region Services

            builder.RegisterType<FoodItemService>().As<IFoodItemService>();

            #endregion

        }
    }
}
