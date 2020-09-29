using Microservices.Product.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Microservices.Product.Database
{
    public sealed class ProductConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.ToTable("Products", "Products");
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Id).ValueGeneratedOnAdd().IsRequired();
            builder.Property(product => product.Description).HasMaxLength(250).IsRequired();
            builder.Property(product => product.Price).HasColumnType("decimal(18,4)").IsRequired();
        }
    }
}
