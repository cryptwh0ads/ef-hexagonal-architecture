using System;
using System.Linq;
using Flunt.Notifications;
using Journey.Modules.Application.Abstractions.Commands;
using Journey.Modules.Application.InputPorts.Employee;
using Journey.Modules.Domain.Entities;
using Journey.Modules.Domain.ValueObjects;

namespace Journey.Modules.Application.UseCases.AddEmployee;

public class AddEmployeeUseCase : Notifiable<Notification>, IAddEmployeeUseCase
{
    private readonly IEmployeeWriteRepository _employeeWriteRepository;

    private Employee _employee;

    public AddEmployeeUseCase(
        IEmployeeWriteRepository employeeWriteRepository)
    {
        _employeeWriteRepository = employeeWriteRepository;
    }

    public string Execute(AddEmployeeInput employee)
    {
        var name = new NameVo(employee.Name);
        var email = new EmailVo(employee.Email);
        _employee = new Employee(name, email, employee.Phone);

        if (!_employee.IsValid)
        {
            AddNotification("Employee", "Erros identificados nos dados do funcionário: ");
            return _employee.Notifications.FirstOrDefault().Message;
        }

        string employeeId;

        try
        {
            employeeId = _employeeWriteRepository.AddEmployee(_employee);
        }
        catch
        {
            throw new Exception($"Error executing AddEmployeeUseCase > Execute()");
        }

        return "Id do funcionário: " + employeeId;
    }
}