using Microsoft.Extensions.DependencyInjection;

namespace Journey.Adapters.Postgres;

public class PgDatabaseAdapter
{
    public  void AddPgDatabaseAdapter(IServiceCollection services)
    {
        services.AddDbContext<PgContext>();
    }
}