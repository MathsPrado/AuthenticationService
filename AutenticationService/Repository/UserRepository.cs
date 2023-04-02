using AutenticationService.Models;

namespace AutenticationService.Repository.Interface
{
    public class UserInterface : IUserInterface
    {
        public async Task<User> Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "Batman", Password = "Batman", Role = "Manager" });
            users.Add(new User { Id = 2, Username = "Robin", Password = "Robin", Role = "Employee" });

            var result = users.FirstOrDefault(x => x.Username.ToLower() == username.ToLower() && x.Password == x.Password);
            return result;


        }
    }
}
