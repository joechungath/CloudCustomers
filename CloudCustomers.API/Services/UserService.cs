using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public interface IUserService {
    Task<List<User>> GetAllUsers();
    }
    public class UserService : IUserService
    {
        public async Task<List<User>> GetAllUsers()
        {
            throw new NotImplementedException();   
        //    List<User> users = new List<User>();
        //    users.Add(new User() { Id=1,Name="Joe",Email="jj@jj.com",Address= new Address() { City="Dallas",PostalCode="75056",Street="WebChapel"} });
        //    return users;
        }
    }
}
