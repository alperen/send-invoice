using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    public class Company
    {
        [Key]
        public int id { get; set; }
        public string displayName { get; set; }
        public bool active { get; set; }
        public string address { get; set; }
        public string taxId { get; set; }
        public string taxOfficeId { get; set; }
        public string registeredNumber { get; set; }
    }
}
