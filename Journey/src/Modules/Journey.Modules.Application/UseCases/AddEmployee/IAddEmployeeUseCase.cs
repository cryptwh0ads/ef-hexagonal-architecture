using Journey.Modules.Application.InputPorts.Employee;

namespace Journey.Modules.Application.UseCases.AddEmployee;

public interface IAddEmployeeUseCase
{
    string Execute(AddEmployeeInput employeeInput);
}