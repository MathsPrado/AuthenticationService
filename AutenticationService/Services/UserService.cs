using AutenticationService.DTOs;
using AutenticationService.Repository.Interface;
using AutenticationService.Services.Interface;
using AutoMapper;
using System;

namespace AutenticationService.Services
{
    public class UserService : IUserService
    {

        private readonly IUserInterface _repository;
        private readonly IMapper _mapper;

        public UserService(IUserInterface repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<UserDTO> Get(string username, string password)
        {
            try
            {
                return _mapper.Map<UserDTO>(_repository.Get(username, password));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
