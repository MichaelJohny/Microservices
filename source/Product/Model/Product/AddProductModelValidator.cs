namespace Microservices.Product.Model
{
    public sealed class AddProductModelValidator : ProductModelValidator
    {
        public AddProductModelValidator()
        {
            Description();
            Price();
        }
    }
}
