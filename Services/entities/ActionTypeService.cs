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
    public class ActionTypeService:IService<ActionTypeDTO>
    {
        private readonly IMapper _mapper;
        private readonly Ientity<ActionType> _actionTypeRepository;

        public ActionTypeService(IMapper mapper, Ientity<ActionType> actionTypeRepository)
        {
            _mapper = mapper;
            _actionTypeRepository = actionTypeRepository;
        }

        public async Task<ActionTypeDTO> Add(ActionTypeDTO entity)
        {
            return _mapper.Map<ActionTypeDTO>(await _actionTypeRepository.Add(_mapper.Map<ActionType>(entity)));
        }

        public async Task Delete(int id)
        {
            await _actionTypeRepository.Delete(id);
        }

        public async Task<List<ActionTypeDTO>> GetAll()
        {
            return _mapper.Map<List<ActionTypeDTO>>(await _actionTypeRepository.GetAll());
        }

        public async Task<ActionTypeDTO> GetById(int id)
        {
            return _mapper.Map<ActionTypeDTO>(await _actionTypeRepository.GetById(id));
        }

        public async Task<ActionTypeDTO> Update(ActionTypeDTO entity)
        {
            return _mapper.Map<ActionTypeDTO>(await _actionTypeRepository.Update(_mapper.Map<ActionType>(entity)));
        }
    }
}
