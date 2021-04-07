using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.DBContexts
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base() { }
        public DbSet<SendInvoiceProject.Business.Company> Companies { get; set; }
    }
}