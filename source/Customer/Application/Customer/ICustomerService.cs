using DotNetCore.Results;
using Microservices.Customer.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Customer.Application
{
    public interface ICustomerService
    {
        Task<IResult<long>> AddAsync(CustomerModel model);

        Task<IResult> DeleteAsync(long id);

        Task<CustomerModel> GetAsync(long id);

        Task<IEnumerable<CustomerModel>> ListAsync();

        Task<IResult> UpdateAsync(CustomerModel model);
    }
}
