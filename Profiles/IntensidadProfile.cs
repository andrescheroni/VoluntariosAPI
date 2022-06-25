using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Profiles
{
    public class IntensidadesProfile : Profile
    {
        public IntensidadesProfile()
        {
            CreateMap<Intensidad, IntensidadReadDto>();
        }
    }
}
