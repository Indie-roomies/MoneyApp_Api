using Microsoft.EntityFrameworkCore;
using MoneyApp_Api.Models;


namespace MoneyApp_Api.Services;


public class JobService : IJobService
{
    public railwayContext _context;

    public JobService(railwayContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Job>> GetJobs()
    {
        var res = await _context.Jobs.ToListAsync();
        return res;
    }
}

public interface IJobService
{
    Task<IEnumerable<Job>> GetJobs();
}