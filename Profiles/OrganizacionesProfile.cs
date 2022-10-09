using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Profiles
{
    public class OrganizacionesProfile : Profile
    {
        public OrganizacionesProfile()
        {
            CreateMap<Organizacion, OrganizacionReadDto>();            
            CreateMap<Organizacion, OrganizacionHashDto>();
            CreateMap<OrganizacionCreateDto, Organizacion>();
            CreateMap<OrganizacionUpdateDto, Organizacion>();
            CreateMap<Organizacion, OrganizacionUpdateDto>();
        }
    }
}
