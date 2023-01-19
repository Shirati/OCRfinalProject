using AutoMapper;
using common.DTOs;
using repositories.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Action = repositories.entities.Action;

namespace Services
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Action, ActionDTO>().ReverseMap();
            CreateMap<ActionType, ActionTypeDTO>().ReverseMap();
            CreateMap<Permission, PermissionDTO>().ReverseMap();
            CreateMap<Picture, PictureDTO>().ReverseMap(); 
        }
    }
}
