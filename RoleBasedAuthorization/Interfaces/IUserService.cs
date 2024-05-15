using RoleBasedAuthorization.Models;

namespace RoleBasedAuthorization.Interfaces
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
