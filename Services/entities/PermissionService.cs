using AutoMapper;
using common.DTOs;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.entities
{
    public class PermissionService:IService<PermissionDTO>
    {
        private readonly IMapper _mapper;
        private readonly Ientity<Permission> _permissionRepository;

        public PermissionService(IMapper mapper, Ientity<Permission> permissionRepository)
        {
            _mapper = mapper;
            _permissionRepository = permissionRepository;
        }

        public async Task<PermissionDTO> Add(PermissionDTO entity)
        {
            return _mapper.Map<PermissionDTO>(await _permissionRepository.Add(_mapper.Map<Permission>(entity)));
        }

        public async Task Delete(int id)
        {
            await _permissionRepository.Delete(id);
        }

        public async Task<List<PermissionDTO>> GetAll()
        {
            return _mapper.Map<List<PermissionDTO>>(await _permissionRepository.GetAll());
        }

        public async Task<PermissionDTO> GetById(int id)
        {
            return _mapper.Map<PermissionDTO>(await _permissionRepository.GetById(id));
        }

        public async Task<PermissionDTO> Update(PermissionDTO entity)
        {
            return _mapper.Map<PermissionDTO>(await _permissionRepository.Update(_mapper.Map<Permission>(entity)));
        }
    }
}
