using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Microservices.Customer.Database
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            const string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=Microservices.Customers;";

            return new Context(new DbContextOptionsBuilder<Context>().UseSqlServer(connectionString).Options);
        }
    }
}
