using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendInvoiceProject.Business.Helpers.Company
{
    public static class CompanyHelpers
    {
        public static void createCompany(DataAccess.Users creator, string name, string address, string taxId, string taxOffice, string registeredNumber)
        {
            var databaseContext = new SendInvoiceProject.DataAccess.SendInvoiceProjectDatabaseEntities();
            var company = new SendInvoiceProject.DataAccess.Companies();
            var role = new SendInvoiceProject.DataAccess.Roles();
            var randomGenerator = new Random();

            company.id = randomGenerator.Next(100000);
            company.name = name;
            company.address = address;
            company.taxId = taxId;
            company.taxOffice = taxOffice;
            company.registeredNumber = registeredNumber;

            role.id = randomGenerator.Next(100000);
            role.user_id = creator.id;
            role.company_id = company.id;
            role.type = RoleType.Vendor.ToString();

            databaseContext.Companies.Add(company);
            databaseContext.Roles.Add(role);
            databaseContext.SaveChanges();
        }

        public static List<DataAccess.Companies> getCompanyListOfUser(DataAccess.Users user)
        {
            var databaseContext = new DataAccess.SendInvoiceProjectDatabaseEntities();
            var roledCompaniesOfUser = databaseContext.Roles.Where(role => role.user_id == user.id).Select(role => role.company_id).ToArray();

            var companiesOfUser = databaseContext.Companies.Where(company => roledCompaniesOfUser.Contains(company.id));
            var result = companiesOfUser.ToList();

            return companiesOfUser.ToList();
        }

        public static void deleteCompanyById(int id)
        {
            var databaseContext = new DataAccess.SendInvoiceProjectDatabaseEntities();
            var company = databaseContext.Companies.Where(c => c.id == id).FirstOrDefault();
            var rolesOfCompany = databaseContext.Roles.Where(role => role.company_id == id);
            var invoicesOfCompany = databaseContext.Invoices.Where(invoice => invoice.company == id);

            databaseContext.Companies.Remove(company);

            foreach (var role in rolesOfCompany)
            {
                databaseContext.Roles.Remove(role); 
            }

            foreach (var invoice in invoicesOfCompany)
            {
                databaseContext.Invoices.Remove(invoice);
            }
        }

    }
}
