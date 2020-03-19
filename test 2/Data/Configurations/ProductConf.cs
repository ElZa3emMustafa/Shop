using Microsoft.EntityFrameworkCore;
using test_2.Models;

namespace test_2.Data.Configurations
{
    public class ProductConf : IEntityTypeConfiguration<Product>
    {
        //THIS CLASS TO SET TO DATABASE A SPESIFIC NAME == be noted that default name will be taken from proparities class MODLE CLASS
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Product> builder)
        {
            // Create Tables and colom names
            //Fluent API
            builder.Property(p=>p.image).HasColumnName("ImageFileName"); // If u dont want to use image as name of colomn now the name is ImageFileName
            //NOTE --> IF U DONT ADD THIS LINE UP THERE ||| THE TABLE NAME WILL BE DEFAULT OF OBJECT NAME
        }
    }
}
