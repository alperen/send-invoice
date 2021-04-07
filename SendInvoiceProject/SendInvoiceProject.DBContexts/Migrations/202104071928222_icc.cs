namespace SendInvoiceProject.DBContexts.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class icc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.InvoiceEntries", "invoice_id", "dbo.Invoices");
            DropForeignKey("dbo.InvoiceEntries", "product_id", "dbo.Products");
            DropIndex("dbo.InvoiceEntries", new[] { "invoice_id" });
            DropIndex("dbo.InvoiceEntries", new[] { "product_id" });
            DropTable("dbo.InvoiceEntries");
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        displayName = c.String(),
                        pricePerQuantity = c.Single(nullable: false),
                        taxPercentPerQuantity = c.Int(nullable: false),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.InvoiceEntries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        invoice_id = c.Int(),
                        product_id = c.Int(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateIndex("dbo.InvoiceEntries", "product_id");
            CreateIndex("dbo.InvoiceEntries", "invoice_id");
            AddForeignKey("dbo.InvoiceEntries", "product_id", "dbo.Products", "id");
            AddForeignKey("dbo.InvoiceEntries", "invoice_id", "dbo.Invoices", "id");
        }
    }
}
