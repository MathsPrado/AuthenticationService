using AutenticationService.DTOs;

namespace AutenticationService.Services.Interface
{
    public interface IUserService
    {
        Task<UserDTO> Get(string username, string password);
    }
}
