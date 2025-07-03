using BlazorWorkOut.Models;
namespace BlazorWorkOut.Components.Pages
{
    public partial class Home
    {
        private List<User>? user;
        private Dictionary<string, object> attributes = new Dictionary<string, object>
        {
            {"placeholder","First Name" },
            {"disabled","disabled" }
        };
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            //user = new List<User>();
            user = new List<User>
            {
                new User
                {
                    UserName = "Bikram",
                    Email = "bikram@gmail.com"
                },
                new User
                {
                    UserName = "Sayan",
                    Email = "sayan@gmail.com"
                }
            };
            await base.OnInitializedAsync();
        }

    }
}
