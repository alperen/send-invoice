using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBContexts
{
    class UserContext : DbContext
    {
        public UserContext() : base() { }
        public DbSet<SendInvoiceProject.Business.User> Users { get; set; } 
    }
}