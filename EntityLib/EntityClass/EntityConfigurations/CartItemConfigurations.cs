using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class CartItemConfigurations:EntityTypeConfiguration<CartItem>
    {
        public CartItemConfigurations()
        {
            Property(c => c.IpAddress)
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsRequired();


            Property(c => c.Quantity)
                .HasColumnType("int")
                .IsRequired();

            Property(c => c.Size)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();



        }
    }
}