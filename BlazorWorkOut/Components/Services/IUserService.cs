using BlazorWorkOut.Models;

namespace BlazorWorkOut.Components.Services
{
    public interface IUserService
    {
        List<User> GetUser();
        void AddUser(User user);
    }
}
