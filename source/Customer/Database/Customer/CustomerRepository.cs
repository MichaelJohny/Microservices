using DotNetCore.EntityFrameworkCore;
using Microservices.Customer.Domain;
using Microservices.Customer.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Customer.Database
{
    public sealed class CustomerRepository : EFRepository<CustomerEntity>, ICustomerRepository
    {
        public CustomerRepository(Context context) : base(context) { }

        public Task<CustomerModel> GetModelAsync(long id)
        {
            return Queryable.Where(CustomerExpression.Id(id)).Select(CustomerExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CustomerModel>> ListModelAsync()
        {
            return await Queryable.Select(CustomerExpression.Model).ToListAsync();
        }
    }
}
