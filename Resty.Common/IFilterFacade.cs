using Resty.Common.FilterParameters;

namespace Resty.Common
{
    public interface IFilterFacade
    {
        #region Methods

        IFoodItemFilterParameters CreateFoodItemFilterParameters();

        #endregion Methods
    }
}