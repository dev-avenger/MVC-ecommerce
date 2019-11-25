using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class CustomerOrderConfigrations : EntityTypeConfiguration<CustomerOrder>
    {
        public CustomerOrderConfigrations()
        {
            //HasKey(s => new { s.CustomerId, s.ProductId, s.cartitems });

            Property(c => c.DueAmount)
               .HasColumnType("float")
               .IsRequired();


            Property(c => c.InvoiceNo)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(c => c.OrderDate)
                .HasColumnType("datetime")
                .IsRequired();

            //HasRequired<Customer>(c => c.customer)
            //    .WithMany(o => o.customerorders)
            //    .HasForeignKey(s => new { s.CustomerId,s.ProductId,s.cartitems});

            //HasMany<CartItem>(c => c.cartitems)
            //    .WithRequired(p => p.customerorder)
            //    .HasForeignKey(s => new { s.ProductId, s.CustomerOrderId });
        }
    }
}