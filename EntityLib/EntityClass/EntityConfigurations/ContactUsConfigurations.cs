using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class ContactUsConfigurations:EntityTypeConfiguration<ContactUs>
    {
        public ContactUsConfigurations()
        {
            Property(a => a.Time)
                .HasColumnType("datetime")
                .IsRequired();

            Property(a => a.Name)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.Email)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.Subject)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(a => a.Message)
                .HasColumnType("varchar")
                .HasMaxLength(5000)
                .IsOptional();
        }
    }
}