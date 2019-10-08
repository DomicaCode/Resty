using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resty.Common
{
    public class FilterFacade : IFilterFacade
    {
        public FilterFacade(ILifetimeScope scope)
        {
            this._scope = scope;
        }

        private readonly ILifetimeScope _scope;

        public TFilter Get<TFilter>()
        {
            return this._scope.Resolve<TFilter>();
        }
    }
}
