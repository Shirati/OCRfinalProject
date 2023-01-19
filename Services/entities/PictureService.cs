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
    public class PictureService : IService<PictureDTO>
    {
        private readonly IMapper _mapper;
        private readonly Ientity<Picture> _pictureRepository;
        public PictureService(IMapper mapper, Ientity<Picture> pictureRepository)
        {
            _mapper = mapper;
            _pictureRepository = pictureRepository;
        }

        public async Task<PictureDTO> Add(PictureDTO entity)
        {
            return _mapper.Map<PictureDTO>(await _pictureRepository.Add(_mapper.Map<Picture>(entity)));
        }

        public async Task Delete(int id)
        {
            await _pictureRepository.Delete(id);
        }

        public async Task<List<PictureDTO>> GetAll()
        {
            return _mapper.Map<List<PictureDTO>>(await _pictureRepository.GetAll());
        }

        public async Task<PictureDTO> GetById(int id)
        {
            return _mapper.Map<PictureDTO>(await _pictureRepository.GetById(id));
        }

        public async Task<PictureDTO> Update(PictureDTO entity)
        {
            return _mapper.Map<PictureDTO>(await _pictureRepository.Update(_mapper.Map<Picture>(entity)));
        }
    }
}
