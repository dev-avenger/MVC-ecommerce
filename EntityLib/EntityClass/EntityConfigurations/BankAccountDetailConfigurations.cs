using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass.EntityConfigurations
{
    public class BankAccountDetailConfigurations : EntityTypeConfiguration<BankAccountDetail>
    {
        public BankAccountDetailConfigurations()
        {
            Property(a => a.BankName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.AccountNumber)
                .HasColumnType("varchar")
                .HasMaxLength(100)
                .IsRequired();

            Property(a => a.BranchCode)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

            Property(a => a.BranchName)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();
        }

    }
}