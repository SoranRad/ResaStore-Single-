using Nz.Aqsat.DataLayer.Context;
using Nz.Bar.DataLayer.Context;

namespace Nz.Aqsat.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AqsatContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            //SetHistoryContextFactory();
            ContextKey = nameof(AqsatContext);
        }

        protected override void Seed(AqsatContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
