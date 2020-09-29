using Microservices.Customer.Domain;
using Microservices.Customer.Model;

namespace Microservices.Customer.Application
{
    public interface ICustomerFactory
    {
        CustomerEntity Create(CustomerModel model);
    }
}
