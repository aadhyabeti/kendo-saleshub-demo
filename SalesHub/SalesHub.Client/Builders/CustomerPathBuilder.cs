using System;
using SalesHub.Core.Models;

namespace SalesHub.Client.Builders
{
    public class CustomerPathBuilder : ICustomerPathBuilder
    {
        private const string PATH_FORMAT = "{0} &raquo; {1}";

        public string BuildCustomerPath(SellingCompany sellingCompany, Customer customer)
        {
            return String.Format(PATH_FORMAT, sellingCompany.CompanyName, customer.CustomerName);
        }
    }
}