using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class CustomerConfigurations : EntityTypeConfiguration<Customer>
    {
        public CustomerConfigurations()
        {

            //HasKey(c => new { c.CustomerId, c.payments });

           

            Property(c => c.CustomerName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();


            Property(c => c.CustomerEmail)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.CustomerPass)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(c => c.CustomerCountry)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.CustomerCity)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.CustomerContact)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(c => c.CustomerAddress)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();


            Property(c => c.CustomerImage)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            HasMany<Payment>(p => p.payments)
                .WithRequired(c => c.customer);

        }
    }
}