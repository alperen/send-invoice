using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SendInvoiceProject.Web
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signupButton_Click(object sender, EventArgs e)
        {
            var isValid = Business.Rules.ValidationRules.isSignupFormValid(email.Text, password.Text, firstName.Text, lastName.Text);

            if (!isValid)
            {
                // TODO Will be implented
                return;
            }

            var hashedPassword = Business.Cyrpto.Md5Hasher.toMd5(password.Text);
            var user = new Business.User();
            var databaseContext = new DataAccess.DatabaseContext();


            user.email = email.Text;
            user.password = hashedPassword;
            user.firstName = firstName.Text;
            user.lastName = lastName.Text;
            user.active = true;


            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();

            Response.Redirect("/login");
        }
    }
}