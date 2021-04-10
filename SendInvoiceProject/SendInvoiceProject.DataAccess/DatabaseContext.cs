using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SendInvoiceProject.Business;

namespace SendInvoiceProject.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base() { }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceEntry> InvoiceEntries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
