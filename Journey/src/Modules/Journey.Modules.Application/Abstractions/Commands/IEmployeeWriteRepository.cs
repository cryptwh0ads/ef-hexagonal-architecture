using Journey.Modules.Domain.Entities;

namespace Journey.Modules.Application.Abstractions.Commands;

public interface IEmployeeWriteRepository
{
    string AddEmployee(Employee employee);
}