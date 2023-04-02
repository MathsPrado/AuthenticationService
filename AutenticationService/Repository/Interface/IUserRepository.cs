using AutenticationService.Models;

namespace AutenticationService.Repository.Interface
{
    public interface IUserInterface
    {
        Task<User> Get(string username, string password);
    }
}
