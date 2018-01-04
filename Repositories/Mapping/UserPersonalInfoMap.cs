using Domain.CoreModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Mapping
{
    public class UserPersonalInfoMap:EntityTypeConfiguration<UserPersonalInfo>
    {
        public UserPersonalInfoMap()
        {
            //PrimaryKey
            HasKey(t => t.RowID);

            // Properties
            Property(t => t.NickName).IsOptional();
            Property(t => t.AddTime).IsRequired();
            Property(t => t.AddUserID).IsRequired();

            // Table & Column Mappings
            ToTable("UserPersonalInfoes");
            this.Property(t => t.RowID).HasColumnName("RowID");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.AddTime).HasColumnName("AddTime");
            this.Property(t => t.AddUserID).HasColumnName("AddUserID");
        }

    }
}
