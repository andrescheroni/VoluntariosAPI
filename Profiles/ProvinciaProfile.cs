using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Profiles
{
    public class ProvinciasProfile : Profile
    {
        public ProvinciasProfile()
        {
            CreateMap<Provincia, ProvinciaReadDto>();
        }
    }
}
