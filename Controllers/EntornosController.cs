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
    [Route("api/entornos")]
    [ApiController]
    public class EntornosController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public EntornosController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/entornos
        [HttpGet]
        public ActionResult<IEnumerable<EntornoReadDto>> GetAllEntornos()
        {
            var entornoItems = _repository.GetAllEntornos();

            return Ok(_mapper.Map<IEnumerable<EntornoReadDto>>(entornoItems));
        }

        //GET api/entornos/{id}
        [HttpGet("{id}", Name = "GetEntornoById")]
        public ActionResult<EntornoReadDto> GetEntornoById(int id)
        {
            var entornoItem = _repository.GetEntornoById(id);

            if (entornoItem != null)
            {
                return Ok(_mapper.Map<EntornoReadDto>(entornoItem));
            }
            return NotFound();
        }

    }
}
