using Resty.Model.Common.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Resty.Model.Models
{
    public class BaseModel : IBaseModel
    {
        #region Properties

        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        #endregion Properties
    }
}