using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            var hashedPassword = Business.Cyrpto.Md5Hasher.toMd5(password);
            var databaseContext = new SendInvoiceProject.DataAccess.SendInvoiceProjectDatabaseEntities();
            var givenUser = databaseContext.Users.Where(user => user.email == email && user.password == hashedPassword).FirstOrDefault();
        
            if (givenUser == null)
            {
                alertMessage.Text = "User not found";
                return;
            }
        }
    }
}