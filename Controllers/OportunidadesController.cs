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
    [Route("api/oportunidades")]
    [ApiController]
    public class OportunidadesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public OportunidadesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/oportunidades
        [HttpGet]
        public ActionResult<IEnumerable<OportunidadReadDto>> GetAllOportunidades()
        {
            var oportunidadItems = _repository.GetAllOportunidades();

            return Ok(_mapper.Map<IEnumerable<OportunidadReadDto>>(oportunidadItems));
        }

        //GET api/oportunidades/{id}
        [HttpGet("{id}", Name = "GetOportunidadById")]
        public ActionResult<OportunidadReadDto> GetOportunidadById(int id)
        {
            var oportunidadItem = _repository.GetOportunidadById(id);

            if (oportunidadItem != null)
            {
                return Ok(_mapper.Map<OportunidadReadDto>(oportunidadItem));
            }
            return NotFound();
        }

        //POST api/oportunidades
        [HttpPost]
        public ActionResult<OportunidadReadDto> CreateOportunidad(OportunidadCreateDto oportunidadCreateDto)
        {
            var oportunidadModel = _mapper.Map<Oportunidad>(oportunidadCreateDto);
            _repository.CreateOportunidad(oportunidadModel);
            _repository.SaveChanges();

            var oportunidadReadDto = _mapper.Map<OportunidadReadDto>(oportunidadModel);

            return CreatedAtRoute(nameof(GetOportunidadById), new { Id = oportunidadReadDto.OportunidadID }, oportunidadReadDto);
        }

        //PUT api/oportunidades/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateOportunidad(int id, OportunidadUpdateDto oportunidadUpdateDto)
        {
            var oportunidadModelFromRepo = _repository.GetOportunidadById(id);
            if (oportunidadModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(oportunidadUpdateDto, oportunidadModelFromRepo);

            _repository.UpdateOportunidad(oportunidadModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/oportunidades/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialOportunidadUpdate(int id, JsonPatchDocument<OportunidadUpdateDto> patchDoc)
        {
            var oportunidadModelFromRepo = _repository.GetOportunidadById(id);
            if (oportunidadModelFromRepo == null)
            {
                return NotFound();
            }

            var oportunidadToPatch = _mapper.Map<OportunidadUpdateDto>(oportunidadModelFromRepo);
            patchDoc.ApplyTo(oportunidadToPatch, ModelState);

            if (!TryValidateModel(oportunidadToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(oportunidadToPatch, oportunidadModelFromRepo);

            _repository.UpdateOportunidad(oportunidadModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/oportunidades/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOportunidad(int id)
        {
            var oportunidadModelFromRepo = _repository.GetOportunidadById(id);
            if (oportunidadModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteOportunidad(oportunidadModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

    }
}
