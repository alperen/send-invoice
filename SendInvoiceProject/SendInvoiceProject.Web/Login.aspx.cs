using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SendInvoiceProject.Business.Helpers.User;

namespace SendInvoiceProject.Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            var email = EmailInput.Text;
            var password = PasswordInput.Text;
            var isValid = Business.Rules.ValidationRules.isLoginFormValid(email, password);

            if (!isValid)
            {
                alertMessage.Text = "The form is invalid";
                return;
            }

            var hashedPassword = Business.Cyrpto.Md5Hasher.toMd5(password);
            var givenUser = UserHelpers.getUserByCredentials(email, hashedPassword);

            if (givenUser == null)
            {
                alertMessage.Text = "User not found";
                return;
            }
        }
    }
}