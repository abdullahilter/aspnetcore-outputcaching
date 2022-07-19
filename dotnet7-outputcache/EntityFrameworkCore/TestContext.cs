using Microsoft.EntityFrameworkCore;

namespace dotnet7_outputcache;

public class TestContext : DbContext
{
    public TestContext(DbContextOptions<TestContext> options)
       : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }
}