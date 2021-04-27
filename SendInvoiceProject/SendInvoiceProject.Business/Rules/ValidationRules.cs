using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business.Rules
{
    public static class ValidationRules
    {
        static bool isValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool isSignupFormValid(string email, string password, string firstName, string lastName)
        {
            var trimmedEmail = email.Trim();
            var trimmedPassword = password.Trim();
            var trimmedFirstName = firstName.Trim();
            var trimmedLastName = lastName.Trim();

            var nullOrEmptyChecks = new string[] { trimmedEmail, trimmedPassword, trimmedFirstName, trimmedLastName }; 

            foreach (var check in nullOrEmptyChecks)
            {
                if (String.IsNullOrEmpty(check))
                {
                    return true;
                }
            } 

            if (!isValidEmail(email))
            {
                return false;
            } 

            if (password.Length < 16)
            {
                return false;
            }

            return true;
        }

        public static bool isLoginFormValid(string email, string password)
        {
            var trimmedEmail = email.Trim();
            var trimmedPassword = password.Trim();
            var nullOrEmptyChecks = new string[] { trimmedEmail, trimmedPassword };

            foreach (var check in nullOrEmptyChecks)
            {
                if (String.IsNullOrEmpty(check))
                {
                    return false;
                }
            }

            if (!isValidEmail(email))
            {
                return false;
            }

            return true;
        }
    }
}
