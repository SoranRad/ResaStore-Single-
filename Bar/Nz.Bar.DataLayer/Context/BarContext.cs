using Nz.Anbar.Model.Model;
using Nz.Bar.DataLayer.Configure;
using Nz.Bar.Model.Models;
using NZ.Anbar.Model;
using ShareLib.Models;
using System.Data.Common;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using Dialog = ShareLib.Models.Dialog;

namespace  Nz.Bar.DataLayer.Context
{
    public class BarContext : DbContext
    {
        public BarContext    (DbConnection Connection , bool Owner) : base      (Connection,true)
        {
            
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BarContext,   Migrations.Configuration>(true));
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
            
            
        }

        public virtual DbSet<Car>           Cars                    { get; set; }
        public virtual DbSet<BarFactor>     BarFactors              { get; set; }


        protected override void         OnModelCreating     (DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.AddFromAssembly(typeof(BarContext).Assembly);
            modelBuilder.Ignore<FactorHead>();
            modelBuilder.Ignore<FactorDetail>();
            modelBuilder.Ignore<NzObject>();
            modelBuilder.Ignore<FactorItem>();
            modelBuilder.Ignore<Kardex>();
            modelBuilder.Ignore<Year>();
            modelBuilder.Ignore<Unit>();
            modelBuilder.Ignore<ObjectImages>();
            modelBuilder.Ignore<Brand>();
            modelBuilder.Ignore<BasteBandi>();
            modelBuilder.Ignore<PreFactor>();
            modelBuilder.Ignore<PreFactorItems>();
            modelBuilder.Ignore<ImageDocument>();
            modelBuilder.Ignore<PeopleGroup>();
            modelBuilder.Ignore<User>();
            modelBuilder.Ignore<Dialog>();
            modelBuilder.Ignore<State>();
            modelBuilder.Ignore<City>();
            modelBuilder.Ignore<Bank>();
            modelBuilder.Ignore<People>(); 

            modelBuilder.Configurations.Add(new CarConfiguration());
            modelBuilder.Configurations.Add(new BarFactorConfiguration());
            modelBuilder.Configurations.Add(new ErsalKarkhaneConfiguration());
        }
    }
}
