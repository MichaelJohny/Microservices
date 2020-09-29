using DotNetCore.Domain;

namespace Microservices.Shared.Domain
{
    public sealed class Email : ValueObject<string>
    {
        public Email(string value) : base(value) { }
    }
}
