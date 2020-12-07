using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Resty.Model.Models;
using System.Collections;
using System.Collections.Generic;

namespace Resty.DAL.DBContext
{
    public class RestyContext : DbContext
    {
        #region Constructors

        public RestyContext(DbContextOptions options) : base(options)
        {
        }

        #endregion Constructors

        #region Properties

        public DbSet<FoodItem> FoodItem { get; set; }
        public DbSet<FoodItemCategory> FoodItemCategory { get; set; }
        public DbSet<Order> Order { get; set; }

        #endregion Properties
    }
}