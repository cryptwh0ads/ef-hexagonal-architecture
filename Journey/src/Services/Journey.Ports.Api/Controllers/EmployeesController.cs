using Journey.Modules.Application.InputPorts.Employee;
using Journey.Modules.Application.UseCases.AddEmployee;
using Microsoft.AspNetCore.Mvc;

namespace Journey.Ports.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class EmployeesController : Controller
{
    private readonly IAddEmployeeUseCase _addEmployeeService;

    public EmployeesController(IAddEmployeeUseCase addEmployeeService)
    {
        _addEmployeeService = addEmployeeService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(string), 201)]
    [ProducesResponseType(400)]
    [ProducesResponseType(500)]
    public IActionResult Post([FromBody] AddEmployeeInput input)
    {
        var employee = _addEmployeeService.Execute(input);
        Console.WriteLine("Funcionário cadastrado: " + employee);
        return Ok(new { Message = employee });
    }
}