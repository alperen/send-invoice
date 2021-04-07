using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.DBContexts
{
    class InvoiceEntryContext : DbContext
    {
        public InvoiceEntryContext() : base() { }
        public DbSet < SendInvoiceProject.Business.InvoiceEntry > InvoiceEntries { get; set; }
    }
}