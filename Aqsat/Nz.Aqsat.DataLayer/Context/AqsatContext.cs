using ShareLib.Models;
using System.Data.Common;
using System.Data.Entity;
using Dialog = ShareLib.Models.Dialog;

namespace  Nz.Aqsat.DataLayer.Context
{
    public class AqsatContext : DbContext
    {
        public AqsatContext    (DbConnection Connection , bool Owner) : base      (Connection,true)
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AqsatContext,   Migrations.Configuration>(true));
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
            
            
        }

        //public virtual DbSet<Car>           Cars                    { get; set; }
        //public virtual DbSet<BarFactor>     BarFactors              { get; set; }


        protected override void         OnModelCreating     (DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.AddFromAssembly(typeof(BarContext).Assembly);
             
            modelBuilder.Ignore<Year>();
            modelBuilder.Ignore<ImageDocument>();
            modelBuilder.Ignore<PeopleGroup>();
            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Dialog>();
            modelBuilder.Ignore<State>();
            modelBuilder.Ignore<City>();
            modelBuilder.Ignore<Bank>();
            modelBuilder.Ignore<People>(); 
        }
    }
}
