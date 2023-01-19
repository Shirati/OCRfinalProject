using AutoMapper;
using common.DTOs;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using repositories.entities;
using repositories.interfaces;
using repositories.repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Services.entities
{
    public class UserService : IService<UserDTO>
    {
        private readonly IMapper _mapper;
        private readonly Ientity<User> _userRepository;

        public UserService(IMapper mapper, Ientity<User> userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<UserDTO> Add(UserDTO entity)
        {
            return _mapper.Map<UserDTO>(await _userRepository.Add(_mapper.Map<User>(entity)));
        }

        public async Task Delete(int id)
        {
            await _userRepository.Delete(id);
        }

        public async Task<List<UserDTO>> GetAll()
        {
            return _mapper.Map<List<UserDTO>>(await _userRepository.GetAll());
        }

        public async Task<UserDTO> GetById(int id)
        {
            return _mapper.Map<UserDTO>(await _userRepository.GetById(id));
        }

        public async Task<UserDTO> Update(UserDTO entity)
        {
            return _mapper.Map<UserDTO>(await _userRepository.Update(_mapper.Map<User>(entity)));
        }
    }
}
