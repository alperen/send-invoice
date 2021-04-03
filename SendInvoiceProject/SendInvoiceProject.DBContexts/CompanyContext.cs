using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBContexts
{
    class CompanyContext : DbContext
    {
        public CompanyContext() : base() { }
        public DbSet<SendInvoiceProject.Business.Company> Companies { get; set; }
    }
}