using Domain.CoreModels;
using Repositories.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EsbBaseDbContext : DbContext
    {
        static EsbBaseDbContext()
        {
            Database.SetInitializer<EsbBaseDbContext>(null);
        }

        public EsbBaseDbContext()
            : base("Name=EsbContext")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
            this.Configuration.LazyLoadingEnabled = true;
        }

        #region DbSet
        public DbSet<User> Users { get; set; }

        public DbSet<UserPersonalInfo> UserPersonalInfoes { get; set; }

        public DbSet<UserEnterpriseInfo> UserEnterpriseInfoes { get; set; }

        public DbSet<UserJournalResult> UserJournalResults { get; set; }
        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new UserEnterpriseInfoMap());
            modelBuilder.Configurations.Add(new UserJournalResultMap());
            modelBuilder.Configurations.Add(new UserPersonalInfoMap());
        }
    }
}
