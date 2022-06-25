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
    [Route("api/provincias")]
    [ApiController]
    public class ProvinciasController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public ProvinciasController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/provincias
        [HttpGet]
        public ActionResult<IEnumerable<ProvinciaReadDto>> GetAllProvincias()
        {
            var provinciaItems = _repository.GetAllProvincias();

            return Ok(_mapper.Map<IEnumerable<ProvinciaReadDto>>(provinciaItems));
        }

        //GET api/provincias/{id}
        [HttpGet("{id}", Name = "GetProvinciaById")]
        public ActionResult<ProvinciaReadDto> GetProvinciaById(int id)
        {
            var provinciaItem = _repository.GetProvinciaById(id);

            if (provinciaItem != null)
            {
                return Ok(_mapper.Map<ProvinciaReadDto>(provinciaItem));
            }
            return NotFound();
        }

    }
}
