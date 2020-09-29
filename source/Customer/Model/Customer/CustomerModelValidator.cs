using FluentValidation;

namespace Microservices.Customer.Model
{
    public abstract class CustomerModelValidator : AbstractValidator<CustomerModel>
    {
        public void Id() => RuleFor(customer => customer.Id).NotEmpty();

        public void Forename() => RuleFor(customer => customer.Forename).NotEmpty();

        public void Surname() => RuleFor(customer => customer.Surname).NotEmpty();

        public void Email() => RuleFor(customer => customer.Email).NotEmpty().EmailAddress();
    }
}
