using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business
{
    public class Role
    {
        [Key]
        public int id;
        public User user;
        public Company company;
        public RoleType roleType;
    }
}
