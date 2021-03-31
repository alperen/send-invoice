using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.Business.Contexts
{
    class InvoiceContext : System.Data.Entity.DbContext
    {
        public InvoiceContext() : base() { }
        public DbSet<Invoice> Invoice { get; set; }
    }
}
