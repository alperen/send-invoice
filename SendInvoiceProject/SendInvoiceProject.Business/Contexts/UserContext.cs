using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.Business.Contexts
{
    class UserContext : System.Data.Entity.DbContext
    {
        public UserContext() : base() { }
        public DbSet<User> User { get; set; } 
    }
}
