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
    [Route("api/voluntarios")]
    [ApiController]
    public class VoluntariosController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public VoluntariosController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }        
        
        //GET api/voluntarios
        [HttpGet]
        public ActionResult <IEnumerable<VoluntarioReadDto>> GetAllVoluntarios()
        {
            var voluntarioItems = _repository.GetAllVoluntarios();
            
            return Ok(_mapper.Map<IEnumerable<VoluntarioReadDto>>(voluntarioItems));
        }

        //GET api/voluntarios/{id}
        [HttpGet("{id}", Name = "GetVoluntarioById")]
        public ActionResult <VoluntarioReadDto> GetVoluntarioById(int id)
        {
            var voluntarioItem = _repository.GetVoluntarioById(id);

            if(voluntarioItem != null)
            {
                return Ok(_mapper.Map<VoluntarioReadDto>(voluntarioItem));
            }
            return NotFound();
        }

        //GET api/voluntarios/hash/{id}
        [HttpGet("hash/{id}")]
        public ActionResult<VoluntarioHashDto> GetVoluntarioHashById(int id)
        {
            var voluntarioItem = _repository.GetVoluntarioById(id);

            if (voluntarioItem != null)
            {
                return Ok(_mapper.Map<VoluntarioHashDto>(voluntarioItem));
            }
            return NotFound();
        }

        //POST api/voluntarios
        [HttpPost]
        public ActionResult<VoluntarioReadDto> CreateVoluntario(VoluntarioCreateDto voluntarioCreateDto)
        {
            var voluntarioModel = _mapper.Map<Voluntario>(voluntarioCreateDto);
            _repository.CreateVoluntario(voluntarioModel);
            _repository.SaveChanges();

            var voluntarioReadDto = _mapper.Map<VoluntarioReadDto>(voluntarioModel);

            return CreatedAtRoute(nameof(GetVoluntarioById), new { Id = voluntarioReadDto.VolutnarioID }, voluntarioReadDto);
        }

        //PUT api/voluntarios/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateVoluntario(int id, VoluntarioUpdateDto voluntarioUpdateDto)
        {
            var voluntarioModelFromRepo = _repository.GetVoluntarioById(id);
            if (voluntarioModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(voluntarioUpdateDto, voluntarioModelFromRepo);

            _repository.UpdateVoluntario(voluntarioModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/voluntarios/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialVoluntarioUpdate(int id, JsonPatchDocument<VoluntarioUpdateDto> patchDoc)
        {
            var voluntarioModelFromRepo = _repository.GetVoluntarioById(id);
            if (voluntarioModelFromRepo == null)
            {
                return NotFound();
            }

            var voluntarioToPatch = _mapper.Map<VoluntarioUpdateDto>(voluntarioModelFromRepo);
            patchDoc.ApplyTo(voluntarioToPatch, ModelState);

            if (!TryValidateModel(voluntarioToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(voluntarioToPatch, voluntarioModelFromRepo);

            _repository.UpdateVoluntario(voluntarioModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/voluntarios/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteVoluntario(int id)
        {
            var voluntarioModelFromRepo = _repository.GetVoluntarioById(id);
            if (voluntarioModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteVoluntario(voluntarioModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

    }
}
