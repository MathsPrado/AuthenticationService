using AutenticationService.DTOs;
using AutenticationService.Services.Interface;

namespace AutenticationService.Services
{
    public class UserService : IUserService
    {
        public Task<UserDTO> Get(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
