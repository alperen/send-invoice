using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SendInvoiceProject.DataAccess;

namespace SendInvoiceProject.Web.SessionManager
{
    public static class SessionManager
    {
        public static DataAccess.User getUser()
        {
            var userSession = (DataAccess.User) HttpContext.Current.Session[SessionIdentifiers.User];

            return userSession;
        }

        public static void setUser(DataAccess user)
        {
            HttpContext.Current.Session[SessionIdentifiers.User] = user;
        }

        public static void resetUserSession()
        {
            HttpContext.Current.Session[SessionIdentifiers.User] = null;
        }
    }
}