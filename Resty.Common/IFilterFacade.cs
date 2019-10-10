using Resty.Common.FilterParameters;

namespace Resty.Common
{
    public interface IFilterFacade
    {
        IFoodItemFilterParameters CreateFoodItemFilterParameters();
    }
}