using AvonovaVacation.Models;
using AvonovaVacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvonovaVacation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CountryContextController : ControllerBase
    {
        public CountryContextController()
        {
        }

        [HttpGet]
        public ActionResult<CountryContext> Get() => CountryContextService.GetCountryContext();

        [HttpPut("{newCountryCode}/update")]
        public IActionResult Update(string newCountryCode)
        {
            CountryContextService.ChangeCountryContext(newCountryCode);
            return NoContent();
        }
    }
}