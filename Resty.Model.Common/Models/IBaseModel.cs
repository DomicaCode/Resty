using System;

namespace Resty.Model.Common.Models
{
    public interface IBaseModel
    {
        #region Properties

        Guid Id { get; set; }
        string Name { get; set; }

        #endregion Properties
    }
}