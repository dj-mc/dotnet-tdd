using Microsoft.AspNetCore.Mvc;

namespace customers.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    // private readonly ILogger<UsersController> _logger;

    public UsersController()
    {

    }

    // public UsersController(ILogger<UsersController> logger)
    // {
    //     _logger = logger;
    // }

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        return null;
    }
}
