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
    [Route("api/estadopostulaciones")]
    [ApiController]
    public class EstadopostulacionesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public EstadopostulacionesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/estadopostulaciones
        [HttpGet]
        public ActionResult<IEnumerable<EstadopostulacionReadDto>> GetAllEstadopostulaciones()
        {
            var estadopostulacionItems = _repository.GetAllEstadopostulaciones();

            return Ok(_mapper.Map<IEnumerable<EstadopostulacionReadDto>>(estadopostulacionItems));
        }

        //GET api/estadopostulaciones/{id}
        [HttpGet("{id}", Name = "GetEstadopostulacionById")]
        public ActionResult<EstadopostulacionReadDto> GetEstadopostulacionById(int id)
        {
            var estadopostulacionItem = _repository.GetEstadopostulacionById(id);

            if (estadopostulacionItem != null)
            {
                return Ok(_mapper.Map<EstadopostulacionReadDto>(estadopostulacionItem));
            }
            return NotFound();
        }

    }
}
