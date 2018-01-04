using Domain.CoreModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Mapping
{
    public class UserJournalResultMap : EntityTypeConfiguration<UserJournalResult>
    {
        public UserJournalResultMap()
        {
            //PrimaryKey
            HasKey(t => t.RowID);

            // Properties
            Property(t => t.AccountBalance).IsRequired();
            Property(t => t.PrePayBalance).IsRequired();
            Property(t => t.InvoiceableAmount).IsRequired();
            Property(t => t.UpdateTime).IsRequired();
            Property(t => t.RowVersion).IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion();

            // Table & Column Mappings
            ToTable("UserJournalResults");
            this.Property(t => t.RowID).HasColumnName("RowID");
            this.Property(t => t.AccountBalance).HasColumnName("AccountBalance");
            this.Property(t => t.PrePayBalance).HasColumnName("PrePayBalance");
            this.Property(t => t.InvoiceableAmount).HasColumnName("InvoiceableAmount");
            this.Property(t => t.UpdateTime).HasColumnName("UpdateTime");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
            this.HasRequired(t=>t.User).WithRequiredDependent(t=>t.UserJournalResult);
        }
    }
}
