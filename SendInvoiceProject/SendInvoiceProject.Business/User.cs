using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    public class User
    {
        [Key]
        public int id;
        public string email;
        public string firstName;
        public string lastName;
        public bool active;
        public Role[] roles;
    }
}
