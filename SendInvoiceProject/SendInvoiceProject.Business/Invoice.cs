using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    public class Invoice
    {
        [Key]
        public int id { get; set; }
        public User creator { get; set; }
        public Company company { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime deletedAt { get; set; }
        public string pdfPath { get; set; }
        public string displayName { get; set; }
        public InvoiceEntry[] invoiceEntries { get; set; }
    }
}
