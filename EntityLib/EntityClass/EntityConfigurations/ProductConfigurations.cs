using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class ProductConfigurations : EntityTypeConfiguration<Product>
    {
        public ProductConfigurations()
        {
            Property(p => p.Date)
                .HasColumnType("datetime")
                .IsRequired();

            Property(p => p.ProductTitle)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.ProductImg1)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            Property(p => p.ProductImg2)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            Property(p => p.ProductImg3)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            Property(p => p.ProductPrice)
                .HasColumnType("float")
                .IsRequired();

            Property(p => p.ProductDesc)
                .HasColumnType("varchar")
                .HasMaxLength(1000)
                .IsRequired();

            Property(p => p.ProductKeywords)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            HasRequired<ProductCategory>(p => p.productcategory)
                .WithMany(c => c.products)
                .HasForeignKey<int>(p => p.ProductCategoryId);

            HasRequired<Category>(p => p.category)
                .WithMany(c => c.products)
                .HasForeignKey<int>(p => p.CategoryId);

            HasMany<Size>(p => p.size)
                .WithRequired(s => s.product)
                .HasForeignKey<int>(p => p.ProductId);


            //HasMany<CustomerOrder>(c => c.customerorders)
            //    .WithRequired(c => c.product)
            //    .HasForeignKey(c => new { c.ProductId, c.CustomerId, c.cartitems });

        }
    }
}