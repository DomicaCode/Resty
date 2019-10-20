using Autofac;
using Autofac.Extras.AggregateService;
using Resty.Common;
using Resty.Common.FilterParameters;
using Resty.DAL;
using Resty.Repository;
using Resty.Repository.Common;
using Resty.Repository.Common.Repositories;
using Resty.Repository.Repositories;
using Resty.Service.Common.Services;
using Resty.Service.Services;

namespace Resty.Infrastructure
{
    public class DIModule : Module
    {
        #region Methods

        protected override void Load(ContainerBuilder builder)
        {
            #region Repositories

            builder.RegisterGeneric(typeof(BaseRepository<,>))
                .As(typeof(IBaseRepository<,>));

            builder.RegisterType<FoodItemRepository>().As<IFoodItemRepository>();
            builder.RegisterType<FoodItemCategoryRepository>().As<IFoodItemCategoryRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();

            #endregion Repositories

            #region Services

            builder.RegisterType<FoodItemService>().As<IFoodItemService>();
            builder.RegisterType<FoodItemCategoryService>().As<IFoodItemCategoryService>();
            builder.RegisterType<OrderService>().As<IOrderService>();

            #endregion Services

            #region Filters

            builder.RegisterAggregateService<IFilterFacade>();

            builder.RegisterType<FoodItemFilterParameters>().As<IFoodItemFilterParameters>();

            #endregion Filters

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().SingleInstance();
        }

        #endregion Methods
    }
}