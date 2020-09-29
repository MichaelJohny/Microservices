namespace Microservices.Customer.Model
{
    public sealed class UpdateCustomerModelValidator : CustomerModelValidator
    {
        public UpdateCustomerModelValidator()
        {
            Id();
            Forename();
            Surname();
            Email();
        }
    }
}
