using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Profiles
{
    public class OportunidadesProfile : Profile
    {
        public OportunidadesProfile()
        {
            CreateMap<Oportunidad, OportunidadReadDto>();
            CreateMap<OportunidadCreateDto, Oportunidad>();
            CreateMap<OportunidadUpdateDto, Oportunidad>();
            CreateMap<Oportunidad, OportunidadUpdateDto>();
        }
    }
}
