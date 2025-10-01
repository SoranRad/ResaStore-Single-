using ShareLib.Models;
using System.Data.Common;
using System.Data.Entity; 
using Dialog = ShareLib.Models.Dialog;

namespace  Nz.Aqsat.DataLayer.Context
{
    public class SiteContext : DbContext
    {
        public SiteContext    (DbConnection Connection , bool Owner) : base      (Connection,true)
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SiteContext,   Migrations.Configuration>(true));
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
        }

        
         
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

            //modelBuilder.Configurations.Add(new Aqsat_Kind_Config());
            //modelBuilder.Configurations.Add(new Aqsat_Main_Config());
            //modelBuilder.Configurations.Add(new Aqsat_Riz_Config());
            //modelBuilder.Configurations.Add(new Aqsat_SmsLogConfig());
        }
    }
}
