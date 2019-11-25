using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class AdminConfigurations : EntityTypeConfiguration<Admin>
    {
        public AdminConfigurations()
        {

            Property(a => a.AdminName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(a => a.AdminEmail)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.AdminPass)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(a => a.AdminImage)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsOptional();

            Property(a => a.AdminCountry)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsOptional();

            Property(a => a.AdminContact)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();



            Property(a => a.AdminJob)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.AdminAbout)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}