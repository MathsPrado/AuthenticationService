using AutenticationService.DTOs;
using AutenticationService.Services;
using AutenticationService.Services.Interface;
using AutenticationService.Services.Interface.ITokenService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutenticationService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUserService _service;
        private readonly ITokenService _serviceToken; //NAO VAI FICAR AQUI

        public LoginController(IUserService service, ITokenService tokenService)
        {
            _service = service;
            _serviceToken = tokenService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        public async Task<ActionResult<dynamic>> Authenticate([FromBody] UserDTO model)
        {
            var user = await _service.Get(model.Username, model.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuario ou senha invalidos" });
            }

            var token = await _serviceToken.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
