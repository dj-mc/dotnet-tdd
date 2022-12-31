using Microsoft.AspNetCore.Mvc;

namespace customers.API.Controllers;

// Configure controller to serve HTTP API responses
[ApiController]
[Route("[controller]")]
// Base class for MVC controller (sans view support)
public class UsersController : ControllerBase
{
    private readonly IUsersService _users_service;

    // Create UsersController with its interface as a dependency
    public UsersController(IUsersService users_service)
    {
        _users_service = users_service;
    }

    [HttpGet(Name = "GetUsers")]
    public async Task<IActionResult> Get()
    {
        var retrieved_users = await _users_service.GetUsers();
        // OkObjectResult object, producing status code 200
        return Ok("Everything is Good");
    }
}
