using DotNetCore.Domain;
using System;

namespace Microservices.Product.Domain
{
    public class ProductEntity : Entity<long>
    {
        public ProductEntity(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public ProductEntity(long id) : base(id) { }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public void UpdateDescription(string description)
        {
            Description = description;
        }

        public void UpdatePrice(decimal price)
        {
            Price = price;
        }
    }
}
