using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business.Helpers.User
{
    public static class UserHelpers
    {
        public static SendInvoiceProject.DataAccess.User getUserByCredentials(string email, string password)
        {
            var databaseContext = new SendInvoiceProject.DataAccess.SendInvoiceProjectDatabaseEntities();
            var givenUser = databaseContext.Users.Where(user => user.email == email && user.password == hashedPassword).FirstOrDefault();

            return givenUser;
        }
    }
}
