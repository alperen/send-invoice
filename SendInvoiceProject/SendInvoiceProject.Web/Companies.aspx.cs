using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendInvoiceProject.Web
{
    public partial class Compaines : System.Web.UI.Page
    {
        private List<DataAccess.Companies> companies = new List<DataAccess.Companies> { }; 
        protected void Page_Load(object sender, EventArgs e)
        {
            var user = SessionManager.SessionManager.getUser();
            companies = Business.Helpers.Company.CompanyHelpers.getCompanyListOfUser(user);

            CompaniesListRepeat.DataSource = companies;
            CompaniesListRepeat.DataBind();
        }

        protected void CreateACompanyButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("/create-company");
        }

        protected void CompaniesListRepeat_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var command = e.CommandName;
            var argument = e.CommandArgument;

            if (command == "DeleteCompany")
            {
                Business.Helpers.Company.CompanyHelpers.deleteCompanyById(Convert.ToInt32(argument));
            }

            Response.Redirect("companies");
        }

        protected void DeleteCompanyButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}