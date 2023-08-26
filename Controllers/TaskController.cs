using Microsoft.AspNetCore.Mvc;
using MoneyApp_Api.Services;

namespace MoneyApp_Api.Controllers;


[ApiController]
[Route("[controller]")]
public class TaskController : Controller
{
    private readonly IJobService _service;

    public TaskController( IJobService service)
    {
        _service = service;
    }

    [HttpGet("GetTasks")]
    public async Task<IActionResult> GetAllJobs()
    {
        return Ok(await _service.GetJobs());
    }
}
