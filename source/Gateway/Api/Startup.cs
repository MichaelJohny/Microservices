using DotNetCore.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;

namespace Microservices.Gateway.Api
{
    public class Startup
    {
        public void Configure(IApplicationBuilder application)
        {
            application.UseHsts();
            application.UseHttpsRedirection();
            application.UseRouting();
            application.UseEndpoints(endpoints => endpoints.MapGet("/", (context) => context.Response.WriteAsync("Gateway.Api")));
            application.UseOcelot().Wait();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddOcelot(services.Configuration()).AddConsul();
        }
    }
}
