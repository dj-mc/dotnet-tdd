using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

using customers.API.Controllers;

namespace customers.UnitTests.SystemsTests.Controllers;

public class TestUsersController
{
    [Fact]
    public async Task GetStatus200()
    {
        var users_controller_instance = new UsersController();
        var response = (OkObjectResult)await users_controller_instance.Get();
        response.StatusCode.Should().Be(200);
    }
}
