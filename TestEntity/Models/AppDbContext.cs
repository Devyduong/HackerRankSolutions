using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TestEntity.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=SHOP")
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}