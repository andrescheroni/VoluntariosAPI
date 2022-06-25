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
    [Route("api/estadoPostulaciones")]
    [ApiController]
    public class EstadoPostulacionesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public EstadoPostulacionesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/estadoPostulaciones
        [HttpGet]
        public ActionResult<IEnumerable<EstadoPostulacionReadDto>> GetAllEstadoPostulaciones()
        {
            var estadoPostulacionItems = _repository.GetAllEstadoPostulaciones();

            return Ok(_mapper.Map<IEnumerable<EstadoPostulacionReadDto>>(estadoPostulacionItems));
        }

        //GET api/estadoPostulaciones/{id}
        [HttpGet("{id}", Name = "GetEstadoPostulacionById")]
        public ActionResult<EstadoPostulacionReadDto> GetEstadoPostulacionById(int id)
        {
            var estadoPostulacionItem = _repository.GetEstadoPostulacionById(id);

            if (estadoPostulacionItem != null)
            {
                return Ok(_mapper.Map<EstadoPostulacionReadDto>(estadoPostulacionItem));
            }
            return NotFound();
        }

    }
}
