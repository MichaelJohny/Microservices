using DotNetCore.Results;
using Microservices.Product.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Product.Application
{
    public interface IProductService
    {
        Task<IResult<long>> AddAsync(ProductModel model);

        Task<IResult> DeleteAsync(long id);

        Task<ProductModel> GetAsync(long id);

        Task<IEnumerable<ProductModel>> ListAsync();

        Task<IResult> UpdateAsync(ProductModel model);
    }
}
