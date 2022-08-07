using System;

namespace Journey.Modules.Application.InputPorts.Employee;

public sealed class AddEmployeeInput
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}