using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    public class User
    {
        public string id;
        public string email;
        public string firstName;
        public string lastName;
        public bool active;
        public Role[] roles;
    }
}
