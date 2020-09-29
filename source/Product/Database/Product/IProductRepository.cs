using DotNetCore.Repositories;
using Microservices.Product.Domain;
using Microservices.Product.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Product.Database
{
    public interface IProductRepository : IRepository<ProductEntity>
    {
        Task<ProductModel> GetModelAsync(long id);

        Task<IEnumerable<ProductModel>> ListModelAsync();
    }
}
