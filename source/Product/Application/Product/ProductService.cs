using DotNetCore.EntityFrameworkCore;
using DotNetCore.Results;
using DotNetCore.Validation;
using Microservices.Product.Database;
using Microservices.Product.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Product.Application
{
    public sealed class ProductService : IProductService
    {
        private readonly IProductFactory _productFactory;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService
        (
            IProductFactory productFactory,
            IProductRepository productRepository,
            IUnitOfWork unitOfWork
        )
        {
            _productFactory = productFactory;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult<long>> AddAsync(ProductModel model)
        {
            var validation = await new AddProductModelValidator().ValidationAsync(model);

            if (validation.Failed)
            {
                return Result<long>.Fail(validation.Message);
            }

            var product = _productFactory.Create(model);

            await _productRepository.AddAsync(product);

            await _unitOfWork.SaveChangesAsync();

            return Result<long>.Success(product.Id);
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            await _productRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<ProductModel> GetAsync(long id)
        {
            return _productRepository.GetModelAsync(id);
        }

        public async Task<IEnumerable<ProductModel>> ListAsync()
        {
            return await _productRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(ProductModel model)
        {
            var validation = await new UpdateProductModelValidator().ValidationAsync(model);

            if (validation.Failed)
            {
                return Result.Fail(validation.Message);
            }

            var product = await _productRepository.GetAsync(model.Id);

            if (product is null)
            {
                return Result.Success();
            }

            product.UpdateDescription(model.Description);

            product.UpdatePrice(model.Price);

            await _productRepository.UpdateAsync(product.Id, product);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
