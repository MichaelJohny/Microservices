using Microservices.Product.Domain;
using Microservices.Product.Model;

namespace Microservices.Product.Application
{
    public interface IProductFactory
    {
        ProductEntity Create(ProductModel model);
    }
}
