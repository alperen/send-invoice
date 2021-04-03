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
        public int id;
        public User creator;
        public Company company;
        public DateTime createdAt;
        public DateTime updatedAt;
        public DateTime deletedAt;
        public string pdfPath;
        public string displayName;
        public InvoiceEntry[] invoiceEntries;
    }
}
