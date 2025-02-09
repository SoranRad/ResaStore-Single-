using System.Data.Common;
namespace NZ.General.DataLayer
{
    using System.Data.Entity;
    using ShareLib.Models;

    public class GeneralContext : DbContext
    {
        public GeneralContext(DbConnection Connection, bool Owner)
            : base(Connection,true)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<GeneralContext, Migrations.Configuration>(true));
            Database.Initialize(false);
            Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<DailyNote>             tbl_DailyNote           { get; set; }
        public virtual DbSet<Company>               tbl_Info                { get; set; }
        public virtual DbSet<Year>                  tbl_Salmali             { get; set; }
        public virtual DbSet<Description>           tbl_Sharh               { get; set; }
        public virtual DbSet<User>                  tbl_User                { get; set; }
        public virtual DbSet<People>                tbl_Ashxas              { get; set; }
        public virtual DbSet<Bank>                  tbl_Bank                { get; set; }
        public virtual DbSet<PeopleGroup>           tbl_Group_Ashxas        { get; set; }
        public virtual DbSet<State>                 tbl_Ostan               { get; set; }
        public virtual DbSet<City>                  tbl_Shahr               { get; set; }
        public virtual DbSet<Dialog>                tbl_Mokaleme_Ashxas     { get; set; }
        public virtual DbSet<ImageDocument>         tbl_Image               { get; set; }
        public virtual DbSet<Activation>            tbl_Config              { get; set; }


        protected override void     OnModelCreating (DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            
        }
    }
}
