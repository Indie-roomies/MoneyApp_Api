using Microsoft.AspNetCore.Mvc;
using MoneyApp_Api.Services;

namespace MoneyApp_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        

        private readonly IJobService _service;


        public WeatherForecastController( IJobService service)
        {

            _service = service;
        }

      

        [HttpGet("Task")]
        public async Task<IActionResult> GetAllJobs()
        {
            return Ok(await _service.GetJobs());
        }
    }
}