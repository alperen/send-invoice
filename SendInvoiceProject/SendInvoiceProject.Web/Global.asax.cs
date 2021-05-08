using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace SendInvoiceProject.Web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRoutes(RouteTable.Routes);
        }

        void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(
                "LoginRoute",
                "login",
                "~/Login.aspx"
            );

            routes.MapPageRoute(
                "SignupRoute",
                "signup",
                "~/Signup.aspx"
            );

            routes.MapPageRoute(
                "DashboardRoute",
                "dashboard",
                "~/Dashboard.aspx"
            );

            routes.MapPageRoute(
                "CompaniesRoute",
                "companies",
                "~/Companies.aspx"
            );

            routes.MapPageRoute(
                "CreateCompany",
                "companies/create-company",
                "~/CreateCompany.aspx"
            );

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}