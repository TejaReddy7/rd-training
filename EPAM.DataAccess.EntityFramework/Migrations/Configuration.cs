namespace EPAM.DataAccess.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EPAM.DataAccess.EntityFramework.EPAMDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "EPAM.DataAccess.EntityFramework.EPAMDBContext";
        }

        protected override void Seed(EPAM.DataAccess.EntityFramework.EPAMDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
