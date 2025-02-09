using Nz.Machine.DataLayer.Context;

namespace Nz.Machine.DataLayer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MachineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = nameof(MachineContext);
        }

        protected override void Seed(Nz.Machine.DataLayer.Context.MachineContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
