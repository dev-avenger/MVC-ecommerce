using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class ProductCategoryConfigurations : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryConfigurations()
        {
            Property(p => p.ProductCategoryTitle)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(p => p.ProductCategoryDesc)
                .HasColumnType("varchar")
                .HasMaxLength(1000)
                .IsRequired();

        }
    }
}