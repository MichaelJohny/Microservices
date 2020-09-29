using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Microservices.Product.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Microservices.Products;";

            return new Context(new DbContextOptionsBuilder<Context>().UseSqlServer(connectionString).Options);
        }
    }
}
