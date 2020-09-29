using DotNetCore.Repositories;
using Microservices.Customer.Domain;
using Microservices.Customer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Customer.Database
{
    public interface ICustomerRepository : IRepository<CustomerEntity>
    {
        Task<CustomerModel> GetModelAsync(long id);

        Task<IEnumerable<CustomerModel>> ListModelAsync();
    }
}
