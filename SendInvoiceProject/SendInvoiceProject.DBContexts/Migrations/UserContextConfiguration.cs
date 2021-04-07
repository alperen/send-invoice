namespace SendInvoiceProject.DBContexts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class UserContextConfiguration : DbMigrationsConfiguration<SendInvoiceProject.DBContexts.UserContext>
    {
        public UserContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SendInvoiceProject.DBContexts.UserContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
