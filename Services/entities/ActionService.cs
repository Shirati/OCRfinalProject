using AutoMapper;
using common.DTOs;
using repositories.entities;
using repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = repositories.entities.Action;

namespace Services.entities
{
    public class ActionService:IService<ActionDTO>
    {
        private readonly IMapper _mapper;
        private readonly Ientity<Action> _actionRepository;

        public ActionService(IMapper mapper, Ientity<Action> actionRepository)
        {
            _mapper = mapper;
            _actionRepository = actionRepository;
        }

        public async Task<ActionDTO> Add(ActionDTO entity)
        {
            return _mapper.Map<ActionDTO>(await _actionRepository.Add(_mapper.Map<Action>(entity)));
        }

        public async Task Delete(int id)
        {
            await _actionRepository.Delete(id);
        }

        public async Task<List<ActionDTO>> GetAll()
        {
            return _mapper.Map<List<ActionDTO>>(await _actionRepository.GetAll());
        }

        public async Task<ActionDTO> GetById(int id)
        {
            return _mapper.Map<ActionDTO>(await _actionRepository.GetById(id));
        }

        public async Task<ActionDTO> Update(ActionDTO entity)
        {
            return _mapper.Map<ActionDTO>(await _actionRepository.Update(_mapper.Map<Action>(entity)));
        }
    }
}
