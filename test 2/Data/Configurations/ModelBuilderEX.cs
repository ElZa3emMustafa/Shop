using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using test_2.Models;

namespace test_2.Data.Configurations
{
    public static class ModelBuilderEX
    {
        // THIS CLASS TO SET DATA TO DATA BASE...
        public static ModelBuilder Seed(this ModelBuilder MB) {
            //Product[] pro = { }; 
            Product prot = new Product
            {
                id = 1,
                name = "OBBBBA",
                description = "SASA TOTO",
                price = 15,
                image = "f1.jpg"
            };

            // MB.Entity<Product>().HasData(pro); // or
            MB.Entity<Product>().HasData(prot);
            return MB;
        }

    }
}
