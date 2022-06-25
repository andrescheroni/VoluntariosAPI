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
    [Route("api/sociales")]
    [ApiController]
    public class SocialesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public SocialesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/sociales
        [HttpGet]
        public ActionResult<IEnumerable<SocialReadDto>> GetAllSociales()
        {
            var socialItems = _repository.GetAllSociales();

            return Ok(_mapper.Map<IEnumerable<SocialReadDto>>(socialItems));
        }

        //GET api/sociales/{id}
        [HttpGet("{id}", Name = "GetSocialById")]
        public ActionResult<SocialReadDto> GetSocialById(int id)
        {
            var socialItem = _repository.GetSocialById(id);

            if (socialItem != null)
            {
                return Ok(_mapper.Map<SocialReadDto>(socialItem));
            }
            return NotFound();
        }

    }
}
