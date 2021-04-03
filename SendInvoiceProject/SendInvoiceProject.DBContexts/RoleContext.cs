using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBContexts
{
    class RoleContext : DbContext
    {
        public RoleContext() : base() { }
        public DbSet<SendInvoiceProject.Business.Role> Roles { get; set; }
    }
}