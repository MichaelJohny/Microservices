using DotNetCore.AspNetCore;
using DotNetCore.EntityFrameworkCore;
using DotNetCore.IoC;
using Microservices.Product.Application;
using Microservices.Product.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Product.Api
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
            services.AddClassesInterfaces(typeof(IProductService).Assembly);
            services.AddClassesInterfaces(typeof(IProductRepository).Assembly);
        }
    }
}
