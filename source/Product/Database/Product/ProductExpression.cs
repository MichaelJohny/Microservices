using Microservices.Product.Domain;
using Microservices.Product.Model;
using System;
using System.Linq.Expressions;

namespace Microservices.Product.Database
{
    public static class ProductExpression
    {
        public static Expression<Func<ProductEntity, ProductModel>> Model => product => new ProductModel
        {
            Id = product.Id,
            Description = product.Description,
            Price = product.Price
        };

        public static Expression<Func<ProductEntity, bool>> Id(long id)
        {
            return product => product.Id == id;
        }
    }
}
