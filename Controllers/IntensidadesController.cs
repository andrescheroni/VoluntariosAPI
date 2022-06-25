using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VoluntariosAPI.Data;
using VoluntariosAPI.DTOs;
using VoluntariosAPI.Models;

namespace VoluntariosAPI.Controllers
{
    [Route("api/intensidades")]
    [ApiController]
    public class IntensidadesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public IntensidadesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/intensidades
        [HttpGet]
        public ActionResult<IEnumerable<IntensidadReadDto>> GetAllIntensidades()
        {
            var intensidadItems = _repository.GetAllIntensidades();

            return Ok(_mapper.Map<IEnumerable<IntensidadReadDto>>(intensidadItems));
        }

        //GET api/intensidades/{id}
        [HttpGet("{id}", Name = "GetIntensidadById")]
        public ActionResult<IntensidadReadDto> GetIntensidadById(int id)
        {
            var intensidadItem = _repository.GetIntensidadById(id);

            if (intensidadItem != null)
            {
                return Ok(_mapper.Map<IntensidadReadDto>(intensidadItem));
            }
            return NotFound();
        }

    }
}
