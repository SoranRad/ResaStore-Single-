using System.Data.Common;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;

namespace NZ.Xazane.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class XazaneContext : DbContext
    {
        public XazaneContext        (DbConnection Connection,bool Owner)
            : base(Connection,Owner)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<XazaneContext, Migrations.Configuration>(true));
            this.Database.Initialize(false);
            this.Configuration.LazyLoadingEnabled = false;
        }



        public virtual DbSet<ChequeBookDetail>  tbl_Daste_Cheque_Riz    { get; set; }
        public virtual DbSet<ChequeBook>        tbl_Daste_Chque         { get; set; }
        public virtual DbSet<Accounts>          tbl_Hesab_Xazaneh       { get; set; }
        public virtual DbSet<DPOperation>       tbl_Amaliat_DP          { get; set; }
        public virtual DbSet<PayBoxOperation>   tbl_Amaliat_Xazaneh     { get; set; }
        public virtual DbSet<ChequeOperation>   tbl_Amaliat_Check       { get; set; }



        protected override void OnModelCreating         (DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
        }
    }
}
