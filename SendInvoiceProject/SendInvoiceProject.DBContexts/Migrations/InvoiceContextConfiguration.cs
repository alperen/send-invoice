namespace SendInvoiceProject.DBContexts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class InvoiceContextConfiguration : DbMigrationsConfiguration<SendInvoiceProject.DBContexts.InvoiceContext>
    {
        public InvoiceContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SendInvoiceProject.DBContexts.InvoiceContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
