using AvonovaVacation.Models;
using AvonovaVacation.Services;
using Microsoft.AspNetCore.Mvc;

namespace AvonovaVacation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HolidayController : ControllerBase
    {
        public HolidayController()
        {
        }

        [HttpGet]
        public IEnumerable<Holiday> Get() => HolidayService.GetAll();


    }
}