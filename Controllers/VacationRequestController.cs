using AvonovaVacation.Models;
using AvonovaVacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvonovaVacation.Controllers;

[ApiController]
[Route("[controller]")]
public class VacationRequestController : ControllerBase
{
    public VacationRequestController()
    {
    }

    [HttpGet]
    public IEnumerable<VacationRequest> Get() => VacationRequestService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<VacationRequest> Get(int id)
    {
        var vacationRequest = VacationRequestService.Get(id);

        if (vacationRequest == null)
            return NotFound();

        return vacationRequest;
    }

    [HttpPost]
    public IActionResult Post([FromBody] VacationRequest vacationRequest)
    {
        VacationRequestService.AddVacationRequestForEmployee(vacationRequest.EmployeeId, vacationRequest);
        return CreatedAtAction(nameof(Get), new { id = vacationRequest.Id }, vacationRequest);
    }
    [HttpPut("{id}/approve")]
    public IActionResult Approve(int id)
    {
        VacationRequestService.ApproveVacationRequest(id);
        return NoContent();
    }

    [HttpPut("{id}/deny")]
    public IActionResult Deny(int id)
    {
        VacationRequestService.DenyVacationRequest(id);
        return NoContent();
    }
}