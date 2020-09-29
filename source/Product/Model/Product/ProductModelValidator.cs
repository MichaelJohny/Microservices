using FluentValidation;

namespace Microservices.Product.Model
{
    public abstract class ProductModelValidator : AbstractValidator<ProductModel>
    {
        public void Id() => RuleFor(product => product.Id).NotEmpty();

        public void Description() => RuleFor(product => product.Description).NotEmpty();

        public void Price() => RuleFor(product => product.Price).NotEmpty();
    }
}
