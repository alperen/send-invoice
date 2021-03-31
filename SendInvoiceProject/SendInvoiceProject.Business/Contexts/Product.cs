using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SendInvoiceProject.Business.Contexts
{
    class ProductContext : System.Data.Entity.DbContext
    {
        public ProductContext() : base() { }
        public DbSet<Product> Product { get; set; }
    }
}
