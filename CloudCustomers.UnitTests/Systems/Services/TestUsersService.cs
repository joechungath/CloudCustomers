using CloudCustomers.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Systems.Services
{
    public class TestUsersService
    {
        [Fact]
        public async Task GetAllUsers_WhenCalled_InvoKesHttpGetRequest()
        {
            //Arrange
            var sut = new UserService();
            //Act
            await sut.GetAllUsers();
            //Assert
             
        }
    }
}
