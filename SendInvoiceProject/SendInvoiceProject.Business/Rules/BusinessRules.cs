using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business.Rules
{
    class BusinessRules
    {
        public bool viewerCanSeeCompany(User viewer, Company company)
        {
            return viewer.roles.Any(role => role.company.id == company.id);
        }
        
        public bool viewerCanAddInvoiceToCompany(User viewer, Company company)
        {
            if (!viewerCanSeeCompany(viewer, company))
            {
                return false;
            }
            
            var viewerRole = Array.Find(viewer.roles, role => role.company.id == company.id);

            return viewerRole.roleType == RoleType.Vendor;
        }

        public bool viewerCanViewTheInvoice(User viewer, Invoice invoice)
        {
            var company = invoice.company;

            return viewerCanSeeCompany(viewer, company);
        }

        public bool viewerCanRemoveTheInvoice(User viewer, Invoice invoice)
        {
            var company = invoice.company;
            var viewerRole = Array.Find(viewer.roles, role => role.company.id == company.id);

            return viewerRole.roleType == RoleType.Vendor;
        }
    }
}
