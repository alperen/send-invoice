namespace SendInvoiceProject.DBContexts.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class InvoiceEntryContextConfiguration : DbMigrationsConfiguration<SendInvoiceProject.DBContexts.InvoiceEntryContext>
    {
        public InvoiceEntryContextConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SendInvoiceProject.DBContexts.InvoiceEntryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
