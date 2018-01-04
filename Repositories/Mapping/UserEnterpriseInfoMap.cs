using Domain.CoreModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Mapping
{
    public class UserEnterpriseInfoMap : EntityTypeConfiguration<UserEnterpriseInfo>
    {
        public UserEnterpriseInfoMap()
        {
            //PrimaryKey
            HasKey(t => t.RowID);

            // Properties
            Property(t => t.CompanyName).IsOptional();
            Property(t => t.AddTime).IsRequired();
            Property(t => t.AddUserID).IsRequired();

            // Table & Column Mappings
            ToTable("UserEnterpriseInfoes");
            this.Property(t => t.RowID).HasColumnName("RowID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.AddTime).HasColumnName("AddTime");
            this.Property(t => t.AddUserID).HasColumnName("AddUserID");
            this.HasRequired(t => t.User).WithMany(t => t.UserEnterpriseInfoList);
        }
    }
}
