using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.DBContexts
{
    class InvoiceContext : DbContext
    {
        public InvoiceContext() : base() { }
        public DbSet<SendInvoiceProject.Business.Invoice> Invoices { get; set; }
    }
}