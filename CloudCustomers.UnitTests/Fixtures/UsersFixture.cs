using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() => new()
        {
            new User
            {
                Id=1,
                Name="TestUser1",
                Address = new Address()
                {
                    City="Dallas",
                    Street ="123 st",
                    PostalCode="75201"
                },
                Email="Jj@JJ.com"
            },
             new User
            {
                Id=2,
                Name="TestUser2",
                Address = new Address()
                {
                    City="Dallas",
                    Street ="123 st",
                    PostalCode="75201"
                },
                Email="Jj@JJ.com"
            },
              new User
            {
                Id=3,
                Name="TestUser3",
                Address = new Address()
                {
                    City="Dallas",
                    Street ="123 st",
                    PostalCode="75201"
                },
                Email="Jj@JJ.com"
            },
        };

    }
}
