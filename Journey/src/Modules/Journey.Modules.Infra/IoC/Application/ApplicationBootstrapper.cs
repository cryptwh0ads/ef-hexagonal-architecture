using Journey.Modules.Application.UseCases.AddEmployee;
using Microsoft.Extensions.DependencyInjection;

namespace Journey.Modules.Infra.IoC.Application;

internal class ApplicationBootstrapper
{
    internal void ChildServiceRegister(IServiceCollection services)
    {
        services.AddScoped<IAddEmployeeUseCase, AddEmployeeUseCase>();
    }
}