using Microservices.Customer.Domain;
using Microservices.Customer.Model;
using Microservices.Shared.Domain;

namespace Microservices.Customer.Application
{
    public class CustomerFactory : ICustomerFactory
    {
        public CustomerEntity Create(CustomerModel model)
        {
            return new CustomerEntity(new Name(model.Forename, model.Surname), new Email(model.Email));
        }
    }
}
