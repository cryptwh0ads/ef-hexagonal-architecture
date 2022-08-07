using Journey.Modules.Application.Abstractions.Commands;
using Journey.Modules.Domain.Entities;

namespace Journey.Adapters.Postgres.WriteOnlyRepositories;

public class EmployeeWriteRepository : IEmployeeWriteRepository
{
    public string AddEmployee(Employee employee)
    {
        return employee.Name.ToString();
    }
}