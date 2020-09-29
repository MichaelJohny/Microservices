using DotNetCore.EntityFrameworkCore;
using Microservices.Product.Domain;
using Microservices.Product.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Microservices.Product.Database
{
    public sealed class ProductRepository : EFRepository<ProductEntity>, IProductRepository
    {
        public ProductRepository(Context context) : base(context) { }

        public Task<ProductModel> GetModelAsync(long id)
        {
            return Queryable.Where(ProductExpression.Id(id)).Select(ProductExpression.Model).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<ProductModel>> ListModelAsync()
        {
            return await Queryable.Select(ProductExpression.Model).ToListAsync();
        }
    }
}
