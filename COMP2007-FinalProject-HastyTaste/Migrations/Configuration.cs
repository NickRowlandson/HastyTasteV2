namespace COMP2007_FinalProject_HastyTaste.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<COMP2007_FinalProject_HastyTaste.Models.MenuModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = " COMP2007_FinalProject_HastyTaste.Models.MenuItem";
        }

        protected override void Seed(COMP2007_FinalProject_HastyTaste.Models.MenuModel context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
