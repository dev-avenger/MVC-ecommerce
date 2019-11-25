using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class CompanyAddressConfigurations: EntityTypeConfiguration<CompanyAddress>
    {
        public CompanyAddressConfigurations()
        {
            Property(a => a.CompanyName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.ShopNumber)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(a => a.Area)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            Property(a => a.City)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.Country)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.PhoneNumber)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(a => a.MobileNumber)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(a => a.EmailAddress)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}