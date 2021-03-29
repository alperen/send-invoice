using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    class Invoice
    {
        public string id;
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
