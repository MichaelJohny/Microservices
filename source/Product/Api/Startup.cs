using DotNetCore.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Product.Api
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
            application.UseException();
            application.UseHttps();
            application.UseHttpsRedirection();
            application.UseRouting();
            application.UseEndpoints(endpoints => endpoints.MapGet("/", (context) => context.Response.WriteAsync("Product.Api")));
            application.UseResponseCompression();
            ///application.UseAuthentication();
            ///application.UseAuthorization();
            application.UseEndpoints();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddResponseCompression();
            services.AddControllers();
            services.AddContext();
            services.AddServices();
        }
    }
}
