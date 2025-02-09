namespace NZ.Xazane.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<NZ.Xazane.DataLayer.XazaneContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = nameof(XazaneContext);
        }

        protected override void Seed(NZ.Xazane.DataLayer.XazaneContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
