using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DBContexts
{
    class UserContext : DBContext
    {
        public UserContext(): base() { }
        public DbSet<User>
    }
}
