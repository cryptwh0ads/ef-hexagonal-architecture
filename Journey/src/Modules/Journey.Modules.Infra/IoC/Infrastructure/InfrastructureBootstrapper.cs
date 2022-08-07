using Journey.Adapters.Postgres.WriteOnlyRepositories;
using Journey.Modules.Application.Abstractions.Commands;
using Journey.Modules.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace Journey.Modules.Infra.IoC.Infrastructure;

internal class InfrastructureBootstrapper
{
    internal void ChildServiceRegister(IServiceCollection services)
    {
        services.AddScoped<IEmployeeWriteRepository, EmployeeWriteRepository>();
    }
}