using Microservices.Customer.Domain;
using Microservices.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microservices.Customer.Database
{
    public sealed class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable("Customers", "Customers");
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Id).ValueGeneratedOnAdd().IsRequired();
            builder.OwnsOne(customer => customer.Name, customerName =>
            {
                customerName.Property(name => name.Forename).HasColumnName(nameof(Name.Forename)).HasMaxLength(250).IsRequired();
                customerName.Property(name => name.Surname).HasColumnName(nameof(Name.Surname)).HasMaxLength(250).IsRequired();
            });
            builder.OwnsOne(customer => customer.Email, customerEmail =>
            {
                customerEmail.Property(email => email.Value).HasColumnName(nameof(Email)).HasMaxLength(250).IsRequired();
                customerEmail.HasIndex(email => email.Value).IsUnique();
            });
        }
    }
}
