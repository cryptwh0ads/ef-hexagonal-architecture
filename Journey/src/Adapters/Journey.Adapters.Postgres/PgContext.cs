using Journey.Modules.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Employee = Journey.Adapters.Postgres.Models.Employee;

namespace Journey.Adapters.Postgres;

public class PgContext : DbContext
{

    public PgContext(DbContextOptions<PgContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employees { get; set; }
}