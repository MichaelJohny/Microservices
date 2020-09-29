using Microservices.Product.Domain;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Product.Database
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<ProductEntity>(product =>
            {
                product.HasData(new { Id = 1L, Description = "Computer", Price = 5_000M });
                product.HasData(new { Id = 2L, Description = "Car", Price = 50_000M });
                product.HasData(new { Id = 3L, Description = "Rocket", Price = 50_000_000M });
            });
        }
    }
}
