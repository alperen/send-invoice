using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendInvoiceProject.Web.Layout
{
    public partial class NestedMasterPage1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var sessionManager = new SessionManager.SessionManager();
            var user = sessionManager.getUser();

            if (user == null)
            {
                Response.Redirect("/login");
            }
        }
    }
}