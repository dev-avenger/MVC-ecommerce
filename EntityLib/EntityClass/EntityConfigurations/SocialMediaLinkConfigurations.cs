using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class SocialMediaLinkConfigurations : EntityTypeConfiguration<SocialMediaLink>
    {
        public SocialMediaLinkConfigurations()
        {
            Property(a => a.facebook)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(a => a.twitter)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(a => a.instagram)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(a => a.googleplus)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

            Property(a => a.youtube)
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}