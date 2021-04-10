using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendInvoiceProject.Web.SessionManager
{
    public class SessionManager
    {
        public Business.User getUser()
        {
            var userSession = (Business.User) HttpContext.Current.Session[SessionIdentifiers.User];

            return userSession;
        }
    }
}