using Microservices.Customer.Domain;
using Microservices.Customer.Model;
using System;
using System.Linq.Expressions;

namespace Microservices.Customer.Database
{
    public static class CustomerExpression
    {
        public static Expression<Func<CustomerEntity, CustomerModel>> Model => customer => new CustomerModel
        {
            Id = customer.Id,
            Forename = customer.Name.Forename,
            Surname = customer.Name.Surname,
            Email = customer.Email.Value
        };

        public static Expression<Func<CustomerEntity, bool>> Id(long id)
        {
            return customer => customer.Id == id;
        }
    }
}
