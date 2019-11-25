using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class PaymentConfigurations : EntityTypeConfiguration<Payment>
    {
        public PaymentConfigurations()
        {

            HasKey(c => new { c.CustomerId, c.Id });

            Property(p => p.InvoiceNo)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Amount)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.PaymentMode)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.ReferenceNo)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(p => p.Code)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();


            Property(p => p.PaymentDate)
                .HasColumnType("datetime")
                .IsRequired();

            Property(p => p.CustomerIp)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}