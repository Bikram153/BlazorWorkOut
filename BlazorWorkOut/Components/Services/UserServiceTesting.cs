using BlazorWorkOut.Models;

namespace BlazorWorkOut.Components.Services
{
    public class UserServiceTesting : IUserService
    {
        private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }

        public List<User> GetUser()
        {
            return new List<User>()
            {
                new User {
                UserName="rahul das",
                Email="rahul@gmail.com"
                },
                new User
                {
                    UserName="sayan",
                    Email="sayan@gmail.com"
                }
            };
        }
    }
}
