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
        public int id;
        public string displayName;
        public bool active;
        public string address;
        public string taxId;
        public string taxOfficeId;
        public string registeredNumber;
    }
}
