namespace NZ.General.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NZ.General.DataLayer.GeneralContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled  = true;
            AutomaticMigrationDataLossAllowed = true;

            ContextKey = nameof(GeneralContext);
        }

        protected override void Seed(GeneralContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
