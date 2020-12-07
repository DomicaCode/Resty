using Resty.Model.Common.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Resty.Model.Models
{
    [Table("FoodItemCategory")]
    public class FoodItemCategory : BaseModel, IFoodItemCategory, IEquatable<FoodItemCategory>
    {
        #region Properties

        public bool IsEnabled { get; set; }
        public string Name { get; set; } = null!;
        public int SortOrder { get; set; }

        /// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
        /// <param name="other">An object to compare with this object.</param>
        /// <returns>
        ///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
        public bool Equals([AllowNull] FoodItemCategory other)
        {
            return String.Equals(this.Id , other?.Id);
        }

        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        ///   <see langword="true" /> if the specified object  is equal to the current object; otherwise, <see langword="false" />.</returns>
        public override bool Equals([AllowNull] object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;
            var other = obj as FoodItemCategory;
            return Equals(other);
        }

        /// <summary>Serves as the default hash function.</summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        #endregion Properties
    }
}