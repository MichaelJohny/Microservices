using DotNetCore.EntityFrameworkCore;
using DotNetCore.Results;
using DotNetCore.Validation;
using Microservices.Customer.Database;
using Microservices.Customer.Model;
using Microservices.Shared.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Customer.Application
{
    public sealed class CustomerService : ICustomerService
    {
        private readonly ICustomerFactory _customerFactory;
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CustomerService
        (
            ICustomerFactory customerFactory,
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork
        )
        {
            _customerFactory = customerFactory;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult<long>> AddAsync(CustomerModel model)
        {
            var validation = await new AddCustomerModelValidator().ValidationAsync(model);

            if (validation.Failed)
            {
                return Result<long>.Fail(validation.Message);
            }

            var customer = _customerFactory.Create(model);

            await _customerRepository.AddAsync(customer);

            await _unitOfWork.SaveChangesAsync();

            return Result<long>.Success(customer.Id);
        }

        public async Task<IResult> DeleteAsync(long id)
        {
            await _customerRepository.DeleteAsync(id);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }

        public Task<CustomerModel> GetAsync(long id)
        {
            return _customerRepository.GetModelAsync(id);
        }

        public async Task<IEnumerable<CustomerModel>> ListAsync()
        {
            return await _customerRepository.ListModelAsync();
        }

        public async Task<IResult> UpdateAsync(CustomerModel model)
        {
            var validation = await new UpdateCustomerModelValidator().ValidationAsync(model);

            if (validation.Failed)
            {
                return Result.Fail(validation.Message);
            }

            var customer = await _customerRepository.GetAsync(model.Id);

            if (customer is null)
            {
                return Result.Success();
            }

            customer.UpdateName(new Name(model.Forename, model.Surname));

            customer.UpdateEmail(new Email(model.Email));

            await _customerRepository.UpdateAsync(customer.Id, customer);

            await _unitOfWork.SaveChangesAsync();

            return Result.Success();
        }
    }
}
