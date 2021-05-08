using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendInvoiceProject.Web.Companies
{
    public partial class CreateCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void createCompanyButton_Click(object sender, EventArgs e)
        {
            var name = DisplayName.Text;
            var address = Address.Text;
            var taxId = TaxId.Text;
            var taxOffice = TaxOffice.Text;
            var registeredNumber = RegisteredNumber.Text;
            var isValid = Business.Rules.ValidationRules.isCreateCompanyFormValid(name, address, taxId, taxOffice, registeredNumber);

            if (!isValid)
            {
                return;
            }

            var user = SessionManager.SessionManager.getUser();

            Business.Helpers.Company.CompanyHelpers.createCompany(user, name, address, taxId, taxOffice, registeredNumber);
            Response.Redirect("/companies");
        }
    }
}