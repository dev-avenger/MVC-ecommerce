using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class EasyPaisaDetailConfigurations : EntityTypeConfiguration<EasyPaisaDetail>
    {
        public EasyPaisaDetailConfigurations()
        {
            Property(a => a.CategoryName)
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
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}