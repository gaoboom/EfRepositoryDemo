using Domain.CoreModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            //PrimaryKey
            HasKey(t => t.UserID);

            // Properties
            Property(t => t.UserID).IsRequired();
            Property(t => t.UserAccount).HasMaxLength(50).IsRequired();
            Property(t => t.UserPassword).IsRequired();
            Property(t => t.UserType).IsRequired();
            Property(t => t.RowVersion).IsRequired().IsFixedLength().HasMaxLength(8).IsRowVersion();

            // Table & Column Mappings
            ToTable("Users");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.UserAccount).HasColumnName("UserAccount");
            this.Property(t => t.UserPassword).HasColumnName("UserPassword");
            this.Property(t => t.UserType).HasColumnName("UserType");
            this.Property(t => t.RowVersion).HasColumnName("RowVersion");
        }
    }
}
