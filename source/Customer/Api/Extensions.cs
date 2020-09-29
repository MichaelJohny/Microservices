using DotNetCore.AspNetCore;
using DotNetCore.EntityFrameworkCore;
using DotNetCore.IoC;
using Microservices.Customer.Application;
using Microservices.Customer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Customer.Api
{
    public static class Extensions
    {
        public static void AddContext(this IServiceCollection services)
        {
            var connectionString = services.GetConnectionString("Database");
            services.AddContext<Context>(options => options.UseSqlServer(connectionString));
            services.AddUnitOfWork<Context>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddFileExtensionContentTypeProvider();
            services.AddClassesInterfaces(typeof(ICustomerService).Assembly);
            services.AddClassesInterfaces(typeof(ICustomerRepository).Assembly);
        }
    }
}
