using AvonovaVacation.Models;
using AvonovaVacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvonovaVacation.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{
    public EmployeeController()
    {
    }

    [HttpGet]
    public IEnumerable<Employee> Get() => EmployeeService.GetEmployeesByCountryCode(CountryContextService.GetCountryContext().CountryCode);

    [HttpGet("{id}")]
    public ActionResult<Employee> Get(int id)
    {
        var employee = EmployeeService.Get(id);

        if (employee == null)
            return NotFound();

        return employee;
    }

}