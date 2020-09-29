namespace Microservices.Product.Model
{
    public sealed class UpdateProductModelValidator : ProductModelValidator
    {
        public UpdateProductModelValidator()
        {
            Id();
            Description();
            Price();
        }
    }
}
