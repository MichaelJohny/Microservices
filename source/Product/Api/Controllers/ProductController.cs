using DotNetCore.AspNetCore;
using Microservices.Product.Application;
using Microservices.Product.Model;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Microservices.Product.Api
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public Task<IActionResult> AddAsync(ProductModel model)
        {
            return _productService.AddAsync(model).ResultAsync();
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> DeleteAsync(long id)
        {
            return _productService.DeleteAsync(id).ResultAsync();
        }

        [HttpGet("{id}")]
        public Task<IActionResult> GetAsync(long id)
        {
            return _productService.GetAsync(id).ResultAsync();
        }

        [HttpGet]
        public Task<IActionResult> ListAsync()
        {
            return _productService.ListAsync().ResultAsync();
        }

        [HttpPut("{id}")]
        public Task<IActionResult> UpdateAsync(ProductModel model)
        {
            return _productService.UpdateAsync(model).ResultAsync();
        }
    }
}
