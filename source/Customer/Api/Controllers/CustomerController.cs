using DotNetCore.AspNetCore;
using Microservices.Customer.Application;
using Microservices.Customer.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Microservices.Customer.Api
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost]
        public Task<IActionResult> AddAsync(CustomerModel model)
        {
            return _customerService.AddAsync(model).ResultAsync();
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> DeleteAsync(long id)
        {
            return _customerService.DeleteAsync(id).ResultAsync();
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetAsync(long id)
        {
            return _customerService.GetAsync(id).ResultAsync();
        }

        [HttpGet]
        public Task<IActionResult> ListAsync()
        {
            return _customerService.ListAsync().ResultAsync();
        }

        [HttpPut("{id}")]
        public Task<IActionResult> UpdateAsync(CustomerModel model)
        {
            return _customerService.UpdateAsync(model).ResultAsync();
        }
    }
}
