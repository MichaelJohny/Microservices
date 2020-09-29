namespace Microservices.Customer.Model
{
    public sealed class AddCustomerModelValidator : CustomerModelValidator
    {
        public AddCustomerModelValidator()
        {
            Forename();
            Surname();
            Email();
        }
    }
}
