using BlazorWorkOut.Models;

namespace BlazorWorkOut.Components.Services
{
    public class UserService : IUserService
    {
        private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetUser()
        {
            return users;
        }
    }
}
