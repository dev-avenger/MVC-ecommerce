using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class CategoryConfigurations : EntityTypeConfiguration<Category>
    {
        public CategoryConfigurations()
        {
            Property(c => c.CategoryTitle)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(c => c.CategoryDesc)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

            Property(c => c.CategoryLink)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsOptional();

        }
    }
}