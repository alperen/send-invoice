namespace SendInvoiceProject.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbContextInitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        displayName = c.String(),
                        active = c.Boolean(nullable: false),
                        address = c.String(),
                        taxId = c.String(),
                        taxOfficeId = c.String(),
                        registeredNumber = c.String(),
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
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Invoices", t => t.invoice_id)
                .ForeignKey("dbo.Products", t => t.product_id)
                .Index(t => t.invoice_id)
                .Index(t => t.product_id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        createdAt = c.DateTime(nullable: false),
                        updatedAt = c.DateTime(nullable: false),
                        deletedAt = c.DateTime(nullable: false),
                        pdfPath = c.String(),
                        displayName = c.String(),
                        company_id = c.Int(),
                        creator_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Companies", t => t.company_id)
                .ForeignKey("dbo.Users", t => t.creator_id)
                .Index(t => t.company_id)
                .Index(t => t.creator_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        firstName = c.String(),
                        lastName = c.String(),
                        active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
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
                "dbo.Roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        roleType = c.Int(nullable: false),
                        company_id = c.Int(),
                        user_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Companies", t => t.company_id)
                .ForeignKey("dbo.Users", t => t.user_id)
                .Index(t => t.company_id)
                .Index(t => t.user_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "user_id", "dbo.Users");
            DropForeignKey("dbo.Roles", "company_id", "dbo.Companies");
            DropForeignKey("dbo.InvoiceEntries", "product_id", "dbo.Products");
            DropForeignKey("dbo.InvoiceEntries", "invoice_id", "dbo.Invoices");
            DropForeignKey("dbo.Invoices", "creator_id", "dbo.Users");
            DropForeignKey("dbo.Invoices", "company_id", "dbo.Companies");
            DropIndex("dbo.Roles", new[] { "user_id" });
            DropIndex("dbo.Roles", new[] { "company_id" });
            DropIndex("dbo.Invoices", new[] { "creator_id" });
            DropIndex("dbo.Invoices", new[] { "company_id" });
            DropIndex("dbo.InvoiceEntries", new[] { "product_id" });
            DropIndex("dbo.InvoiceEntries", new[] { "invoice_id" });
            DropTable("dbo.Roles");
            DropTable("dbo.Products");
            DropTable("dbo.Users");
            DropTable("dbo.Invoices");
            DropTable("dbo.InvoiceEntries");
            DropTable("dbo.Companies");
        }
    }
}
