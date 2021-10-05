using AutoMapper;
using apiweb.DTOs;
using apiweb.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiweb.Utilidades
{
    //heredo de Profile, que proviene de automapper
    public class AutoMapperProfiles : Profile
    {        
        public AutoMapperProfiles()
        {
            CreateMap<User, UserDTO>().ReverseMap();                                
        }        
    }
}
