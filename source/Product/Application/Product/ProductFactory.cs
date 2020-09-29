using Microservices.Product.Domain;
using Microservices.Product.Model;

namespace Microservices.Product.Application
{
    public class ProductFactory : IProductFactory
    {
        public ProductEntity Create(ProductModel model)
        {
            return new ProductEntity(model.Description, model.Price);
        }
    }
}
