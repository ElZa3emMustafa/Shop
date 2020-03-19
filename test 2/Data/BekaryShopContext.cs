using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_2.Data.Configurations;
using test_2.Models;

namespace test_2.Data
{
    public class BekaryShopContext : DbContext
    {
        public DbSet<Product> Products { set; get; } //Table
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source = Bakary.db");
        }
        //BekaryShopContext db = new BekaryShopContext();

        protected override void OnModelCreating(ModelBuilder mb) {
            mb.ApplyConfiguration(new ProductConf()).Seed(); // ADD DATA TO DB WITH CREATION
        
        }
    
    
    }
}
