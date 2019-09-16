using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Resty.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Resty.DAL.DBContext
{
    public class RestyContext : DbContext
    {
        public RestyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FoodItem> FoodItem { get; set; }

    }
}
