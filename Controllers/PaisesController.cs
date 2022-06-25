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
    [Route("api/paises")]
    [ApiController]
    public class PaisesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public PaisesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/paises
        [HttpGet]
        public ActionResult<IEnumerable<PaisReadDto>> GetAllPaises()
        {
            var paisItems = _repository.GetAllPaises();

            return Ok(_mapper.Map<IEnumerable<PaisReadDto>>(paisItems));
        }

        //GET api/paises/{id}
        [HttpGet("{id}", Name = "GetPaisById")]
        public ActionResult<PaisReadDto> GetPaisById(int id)
        {
            var paisItem = _repository.GetPaisById(id);

            if (paisItem != null)
            {
                return Ok(_mapper.Map<PaisReadDto>(paisItem));
            }
            return NotFound();
        }

    }
}
