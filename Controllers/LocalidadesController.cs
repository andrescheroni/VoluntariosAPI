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
    [Route("api/localidades")]
    [ApiController]
    public class LocalidadesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public LocalidadesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/localidades
        [HttpGet]
        public ActionResult<IEnumerable<LocalidadReadDto>> GetAllLocalidades()
        {
            var localidadItems = _repository.GetAllLocalidades();

            return Ok(_mapper.Map<IEnumerable<LocalidadReadDto>>(localidadItems));
        }

        //GET api/localidades/{id}
        [HttpGet("{id}", Name = "GetLocalidadById")]
        public ActionResult<LocalidadReadDto> GetLocalidadById(int id)
        {
            var localidadItem = _repository.GetLocalidadById(id);

            if (localidadItem != null)
            {
                return Ok(_mapper.Map<LocalidadReadDto>(localidadItem));
            }
            return NotFound();
        }

    }
}
