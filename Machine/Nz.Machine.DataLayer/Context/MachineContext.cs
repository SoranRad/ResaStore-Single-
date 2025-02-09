using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Machine.Model.Model;

namespace Nz.Machine.DataLayer.Context
{
    public class MachineContext : DbContext
    {
        public MachineContext   (DbConnection Connection, bool Owner) : base(Connection, Owner)
        {

            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<MachineContext, Migrations.Configuration>(true));

            this.Database.Initialize                (false);
            this.Configuration.LazyLoadingEnabled   = false;
        }

        public virtual DbSet<AcceptMachine> Machines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
