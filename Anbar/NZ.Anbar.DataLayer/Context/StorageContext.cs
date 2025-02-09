using System.Data.Common;
using Nz.Anbar.Model.Model;
using NZ.Anbar.Model;
using System.Data.Entity;
using System.Data.Entity.Migrations.History; 
using ShareLib.Models;

namespace NZ.Anbar.DataLayer.Context
{
    public class StorageContext : DbContext
    {
        public StorageContext    (DbConnection Connection , bool Owner) : base      (Connection,true)
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StorageContext, Migrations.Configuration>(true));
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
            
            
        }

        public virtual DbSet<Kardex>            Kadexes             { get; set; }
        public virtual DbSet<FactorItem>        FactorItems         { get; set; }
        public virtual DbSet<FactorHead>        FactorHeads         { get; set; }
        public virtual DbSet<FactorDetail>      FactorDetails       { get; set; }
        public virtual DbSet<Storage>           Storages            { get; set; }
        public virtual DbSet<StorageAccess>     StorageAccessList   { get; set; }
        public virtual DbSet<NzObject>          NzObjects           { get; set; }
        public virtual DbSet<Unit>              Units               { get; set; }
        public virtual DbSet<MainGroup>         MainGroups          { get; set; }
        public virtual DbSet<SubGroup>          SubGroups           { get; set; }
        public virtual DbSet<PreFactor>         PreFactors          { get; set; }
        public virtual DbSet<PreFactorItems>    PreFactorItems      { get; set; }
        public virtual DbSet<BasteBandi>        BsteBandis          { get; set; }
        public virtual DbSet<Brand>             Brands              { get; set; }
        public virtual DbSet<ObjectImages>      ObjectImages        { get; set; }



        protected override void         OnModelCreating     (DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            
        }
    }
}
