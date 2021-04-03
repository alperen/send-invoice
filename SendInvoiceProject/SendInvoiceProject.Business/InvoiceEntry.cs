using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    public class InvoiceEntry
    {
        [Key]
        public int id;
        public Product product;
        public Invoice invoice;
    }
}
