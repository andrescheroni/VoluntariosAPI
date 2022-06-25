using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Profiles
{
    public class PostulacionesProfile : Profile
    {
        public PostulacionesProfile()
        {
            CreateMap<Postulacion, PostulacionReadDto>();
            CreateMap<PostulacionCreateDto, Postulacion>();
            CreateMap<PostulacionUpdateDto, Postulacion>();
            CreateMap<Postulacion, PostulacionUpdateDto>();
        }
    }
}
