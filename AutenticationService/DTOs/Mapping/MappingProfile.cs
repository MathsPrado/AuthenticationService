using AutenticationService.Models;
using AutoMapper;

namespace AutenticationService.DTOs.Mapping
{
    public class MappingProfile : Profile
    {
        protected MappingProfile()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
