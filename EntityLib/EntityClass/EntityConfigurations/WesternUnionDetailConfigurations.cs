using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class WesternUnionDetailConfigurations : EntityTypeConfiguration<WesternUnionDetail>
    {
        public WesternUnionDetailConfigurations()
        {
            Property(a => a.FullName)
               .HasColumnType("varchar")
               .HasMaxLength(50)
               .IsRequired();

            Property(a => a.NICNumber)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.MobileNumber)
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            Property(a => a.AccountName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.Country)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}