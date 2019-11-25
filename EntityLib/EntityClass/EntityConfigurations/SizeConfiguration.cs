using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class SizeConfiguration : EntityTypeConfiguration<Size>
    {
        public SizeConfiguration()
        {
            Property(a => a.size)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}