using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

using customers.API.Controllers;
using customers.API.Models;

namespace customers.UnitTests.SystemsTests.Controllers;

public class TestUsersController
{
    [Fact]
    public async Task GetStatus200()
    {
        // Resolve instance of implemented interface
        var mock_users_service = new Mock<IUsersService>();

        // Setup mocked IUsersService type,
        // returning a List of Users.
        mock_users_service
            .Setup(service => service.GetUsers())
            .ReturnsAsync(new List<User>());

        // Provide service as dependency of UsersController,
        // and access mocked implementation via dot Object.
        var users_controller_instance = new UsersController(mock_users_service.Object);

        var response = (OkObjectResult)await users_controller_instance.Get();
        response.StatusCode.Should().Be(200);
    }

    [Fact]
    public async Task InvokeService()
    {
        var mock_users_service = new Mock<IUsersService>();

        mock_users_service
            .Setup(service => service.GetUsers())
            .ReturnsAsync(new List<User>());

        var users_controller_instance = new UsersController(mock_users_service.Object);
        var response = await users_controller_instance.Get();

        // Verify invocation of service.GetUsers() occurs once
        mock_users_service.
            Verify(service => service.GetUsers(), Times.Once());
    }

    [Fact]
    public async Task ReturnUsersList()
    {
        var mock_users_service = new Mock<IUsersService>();

        mock_users_service
            .Setup(service => service.GetUsers())
            .ReturnsAsync(new List<User>());

        var users_controller_instance = new UsersController(mock_users_service.Object);

        // On successful status code 200
        var response = await users_controller_instance.Get();
        response.Should().BeOfType<OkObjectResult>();
        // Return type should be a List of Users
        var ok_object_result = (OkObjectResult)response;
        ok_object_result.Value.Should().BeOfType<List<User>>();
    }
}
