using Microservices.Customer.Domain;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Customer.Database
{
    public static class ContextSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<CustomerEntity>(customer =>
            {
                customer.HasData(new { Id = 1L });
                customer.OwnsOne(owns => owns.Name).HasData(new { CustomerEntityId = 1L, Forename = "Albert", Surname = "Einstein" });
                customer.OwnsOne(owns => owns.Email).HasData(new { CustomerEntityId = 1L, Value = "albert.einstein@email.com" });

                customer.HasData(new { Id = 2L });
                customer.OwnsOne(owns => owns.Name).HasData(new { CustomerEntityId = 2L, Forename = "Stephen", Surname = "Hawking" });
                customer.OwnsOne(owns => owns.Email).HasData(new { CustomerEntityId = 2L, Value = "stephen.hawking@email.com" });

                customer.HasData(new { Id = 3L });
                customer.OwnsOne(owns => owns.Name).HasData(new { CustomerEntityId = 3L, Forename = "Ada", Surname = "Lovelace" });
                customer.OwnsOne(owns => owns.Email).HasData(new { CustomerEntityId = 3L, Value = "ada.lovelace@email.com" });
            });
        }
    }
}
