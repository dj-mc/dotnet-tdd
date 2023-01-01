using customers.API.Models;

public interface IUsersService
{
    public Task<List<User>> GetUsers();
}
public class UsersService : IUsersService
{
    public Task<List<User>> GetUsers()
    {
        throw new NotImplementedException();
    }
}
