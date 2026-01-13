using ShareLib.Models;
using System.Data.Common;
using System.Data.Entity;
using Nz.Aqsat.DataLayer.Configure;
using Nz.Aqsat.Model.Models;
using Dialog = ShareLib.Models.Dialog;

namespace  Nz.Aqsat.DataLayer.Context
{
    public class AqsatContext : DbContext
    {
        public AqsatContext    (DbConnection Connection , bool Owner) : base      (Connection,true)
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AqsatContext,   Migrations.Configuration>(true));
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = true;
        }

        public virtual DbSet<Aqsat_Kind>    AqsatKinds      { get; set; }
        public virtual DbSet<Aqsat_Main>    AqsatMains      { get; set; }
        public virtual DbSet<Aqsat_Riz>     AqsatRizes      { get; set; }
        public virtual DbSet<Aqsat_SmsLog>  Aqsat_SmsLogs  { get; set; }

        protected override void         OnModelCreating     (DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Year>();
            modelBuilder.Ignore<ImageDocument>();
            modelBuilder.Ignore<PeopleGroup>();
            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Dialog>();
            modelBuilder.Ignore<State>();
            modelBuilder.Ignore<City>();
            modelBuilder.Ignore<Bank>();
            modelBuilder.Ignore<People>(); 

            modelBuilder.Configurations.Add(new Aqsat_Kind_Config());
            modelBuilder.Configurations.Add(new Aqsat_Main_Config());
            modelBuilder.Configurations.Add(new Aqsat_Riz_Config());
            modelBuilder.Configurations.Add(new Aqsat_SmsLogConfig());
        }
    }
}
