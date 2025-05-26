using Microsoft.AspNetCore.Mvc;
using ImagineCars.Models;
using ImagineCars.Interfaces;

namespace ImagineCars.Controllers;

[ApiController]
[Route("Workshops")]
public class WorkshopsController : ControllerBase
{
    private readonly ILogger<WorkshopsController> _logger;
    private readonly IWorkshopRepository _workshopRepository;
    public WorkshopsController(ILogger<WorkshopsController> logger, IWorkshopRepository workshopRepository)
    {
        _logger = logger;
        _workshopRepository = workshopRepository;
    }

    [HttpGet(Name = "GetWorkshops")]
    public async Task<ActionResult<IEnumerable<Workshop>>> GetWorkshops(Guid CompanyId)
    {
        //TODO: Finish this function so it properly returns a list of all the workshops you've added with the function below.
        await _workshopRepository.GetAllWorkshopsForCompany(CompanyId);
        return Ok();
    }

    //TODO: Implement a way to add singular Workshops for some company id.
}
