using System.ComponentModel.DataAnnotations;

namespace Microservices.Auth.Api
{
    public class LoginInputModel
    {
        [Required]
        public string Password { get; set; }

        public bool RememberLogin { get; set; }

        public string ReturnUrl { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
