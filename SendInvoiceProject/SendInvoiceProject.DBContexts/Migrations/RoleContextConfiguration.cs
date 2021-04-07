namespace SendInvoiceProject.DBContexts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class RoleContextConfiguration : DbMigrationsConfiguration<SendInvoiceProject.DBContexts.RoleContext>
    {
        public RoleContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SendInvoiceProject.DBContexts.RoleContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
