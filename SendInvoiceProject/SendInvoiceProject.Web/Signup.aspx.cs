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
            var user = new SendInvoiceProject.DataAccess.Users();
            var databaseContext = new SendInvoiceProject.DataAccess.SendInvoiceProjectDatabaseEntities();
            var randomGenerator = new Random();

            user.id = randomGenerator.Next(100000);
            user.email = email.Text;
            user.password = hashedPassword;
            user.firstName = firstName.Text;
            user.lastName = lastName.Text;
            user.active = 1;


            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();

            Response.Redirect("/login");
        }
    }
}