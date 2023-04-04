using AutenticationService.DTOs;

namespace AutenticationService.Services.Interface.ITokenService
{
    public interface ITokenService
    {
        Task<string> GenerateToken(UserDTO user);
    }
}
