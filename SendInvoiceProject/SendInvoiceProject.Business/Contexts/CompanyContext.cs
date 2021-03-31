using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.Business.Contexts
{
    class CompanyContext : System.Data.Entity.DbContext
    {
        public CompanyContext() : base() { }
        public DbSet<Company> Company { get; set; }
    }
}
