using Microsoft.EntityFrameworkCore;
using Resty.Model.Models;

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

        #endregion Properties
    }
}