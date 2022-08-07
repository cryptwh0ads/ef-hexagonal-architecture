using Journey.Modules.Infra.IoC.Application;
using Journey.Modules.Infra.IoC.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace Journey.Modules.Infra.IoC;

public class RootBootstrapper
{
    public void BootstrapperRegisterServices(IServiceCollection services)
    {
        new ApplicationBootstrapper().ChildServiceRegister(services);
        new InfrastructureBootstrapper().ChildServiceRegister(services);
    }
}