using DotNetCore.Domain;
using Microservices.Shared.Domain;

namespace Microservices.Customer.Domain
{
    public class CustomerEntity : Entity<long>
    {
        public CustomerEntity
        (
            Name name,
            Email email
        )
        {
            Name = name;
            Email = email;
        }

        public CustomerEntity(long id) : base(id) { }

        public Name Name { get; private set; }

        public Email Email { get; private set; }

        public void UpdateName(Name name)
        {
            Name = name;
        }

        public void UpdateEmail(Email email)
        {
            Email = email;
        }
    }
}
