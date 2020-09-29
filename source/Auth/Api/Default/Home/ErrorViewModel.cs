using IdentityServer4.Models;

namespace Microservices.Auth.Api
{
    public class ErrorViewModel
    {
        public ErrorViewModel(ErrorMessage errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public ErrorMessage ErrorMessage { get; set; }
    }
}
