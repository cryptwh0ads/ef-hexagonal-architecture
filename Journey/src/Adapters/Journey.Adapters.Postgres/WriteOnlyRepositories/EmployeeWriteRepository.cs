using Journey.Modules.Application.Abstractions.Commands;
using Journey.Modules.Domain.Entities;

namespace Journey.Adapters.Postgres.WriteOnlyRepositories;

public class EmployeeWriteRepository : IEmployeeWriteRepository
{
    private readonly PgContext _context;

    public EmployeeWriteRepository(PgContext context)
    {
        _context = context;
    }
    
    public string AddEmployee(Employee employee)
    {
        // var addedEmployee = _context.Add(employee);

        return employee.Name.ToString();
    }
}