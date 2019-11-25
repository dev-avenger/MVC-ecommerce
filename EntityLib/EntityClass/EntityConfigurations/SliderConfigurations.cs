using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class SliderConfigurations : EntityTypeConfiguration<Slider>
    {
        public SliderConfigurations()
        {
            Property(s => s.SlideName)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(s => s.SlideImage)
                .HasColumnType("varchar")
                .HasMaxLength(500)
                .IsRequired();

        }
    }
}