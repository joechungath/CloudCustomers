using CloudCustomers.API.Controllers;
using CloudCustomers.API.Models;
using CloudCustomers.API.Services;
using CloudCustomers.UnitTests.Fixtures;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace CloudCustomers.UnitTests.Systems.Controllers;

public class TestUserController
{
    [Fact]
    public async Task Get_OnSucess_ReturnStatusCode200()
    {
        //Arrange
        var mockUserService = new Mock<IUserService>();
        mockUserService.Setup(service => service.GetAllUsers()).ReturnsAsync(UsersFixture.GetTestUsers());
        var sut = new UsersController(mockUserService.Object);
        //Action
        var result = (OkObjectResult)await sut.Get();
        //Assert
        result.StatusCode.Should().Be(200);

    }

    [Fact]
    public async Task Get_OnSuccess_InovokeUserServiceExactlyOnce()
    {
        var mockUsersService = new Mock<IUserService>();
        mockUsersService.Setup(service => service.GetAllUsers()).ReturnsAsync(new List<User>());
        var sut = new UsersController(mockUsersService.Object);
        var result = await sut.Get();
        mockUsersService.Verify(service => service.GetAllUsers(), Times.Once);
    }

    [Fact]
    public async Task Get_OnSuccesReturnListofUsers()
    {
        //Arrange
        var mockuserservice = new Mock<IUserService>();

        mockuserservice
            .Setup(Service => Service.GetAllUsers())
            .ReturnsAsync(UsersFixture.GetTestUsers() );

        var sut = new UsersController(mockuserservice.Object);

        //Act
        var result = await sut.Get();

        //Assert
        result.Should().BeOfType<OkObjectResult>();
        var objResult = (OkObjectResult)result;
        objResult.Value.Should().BeOfType<List<User>>();
    }

    [Fact]
    public async Task Get_NotUsersFoundReturn404()
    {
        var mockuserservice = new Mock<IUserService>();
        mockuserservice.Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());
        var sut = new UsersController(mockuserservice.Object);
        var result = await sut.Get();
        result.Should().BeOfType<NotFoundResult>();
        var objectResult = (NotFoundResult)result;
        objectResult.Should().Be(404);
    }

}