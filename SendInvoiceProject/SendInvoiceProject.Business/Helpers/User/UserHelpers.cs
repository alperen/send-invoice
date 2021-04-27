using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SendInvoiceProject.DataAccess;

namespace SendInvoiceProject.Business.Helpers.User
{
    public static class UserHelpers
    {
        public static DataAccess.Users getUserByCredentials(string email, string hashedPassword)
        {
            var databaseContext = new SendInvoiceProject.DataAccess.SendInvoiceProjectDatabaseEntities();
            var givenUser = databaseContext.Users.Where(user => user.email == email && user.password == hashedPassword).FirstOrDefault();

            return givenUser;
        }
    }
}
