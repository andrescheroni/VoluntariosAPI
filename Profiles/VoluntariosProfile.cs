using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Profiles
{
    public class VoluntariosProfile : Profile
    {
        public VoluntariosProfile()
        {
            CreateMap<Voluntario, VoluntarioReadDto>();
            CreateMap<Voluntario, VoluntarioHashDto>();
            CreateMap<VoluntarioCreateDto, Voluntario>();
            CreateMap<VoluntarioUpdateDto, Voluntario>();
            CreateMap<Voluntario, VoluntarioUpdateDto>();
        }
    }
}
