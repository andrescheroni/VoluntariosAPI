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
    [Route("api/organizaciones")]
    [ApiController]
    public class OrganizacionesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public OrganizacionesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }        
        
        //GET api/organizaciones
        [HttpGet]
        public ActionResult <IEnumerable<OrganizacionReadDto>> GetAllOrganizaciones()
        {
            var organizacionItems = _repository.GetAllOrganizaciones();

            return Ok(_mapper.Map<IEnumerable<OrganizacionReadDto>>(organizacionItems));
        }

        //GET api/organizaciones/{id}
        [HttpGet("{id}", Name ="GetOrganizacionById")]
        public ActionResult <OrganizacionReadDto> GetOrganizacionById(int id)
        {
            var organizacionItem = _repository.GetOrganizacionById(id);

            if(organizacionItem != null)
            {
                return Ok(_mapper.Map<OrganizacionReadDto>(organizacionItem));
            }
            return NotFound();
        }

        //GET api/organizaciones/hash/{id}
        [HttpGet("hash/{id}")]
        public ActionResult<OrganizacionHashDto> GetOrganizacionHashById(int id)
        {
            var organizacionItem = _repository.GetOrganizacionById(id);

            if (organizacionItem != null)
            {
                return Ok(_mapper.Map<OrganizacionHashDto>(organizacionItem));
            }
            return NotFound();
        }

        //POST api/organizaciones
        [HttpPost]
        public ActionResult<OrganizacionReadDto> CreateOrganizacion(OrganizacionCreateDto organizacionCreateDto)
        {
            var organizacionModel = _mapper.Map<Organizacion>(organizacionCreateDto);
            _repository.CreateOrganizacion(organizacionModel);
            _repository.SaveChanges();

            var organizacionReadDto = _mapper.Map<OrganizacionReadDto>(organizacionModel);

            return CreatedAtRoute(nameof(GetOrganizacionById), new { Id = organizacionReadDto.OrganizacionID }, organizacionReadDto);           
        }

        //PUT api/organizaciones/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateOrganizacion(int id, OrganizacionUpdateDto organizacionUpdateDto)
        {
            var organizacionModelFromRepo = _repository.GetOrganizacionById(id);
            if(organizacionModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(organizacionUpdateDto, organizacionModelFromRepo);

            _repository.UpdateOrganizacion(organizacionModelFromRepo);
            
            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/organizaciones/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialOrganizacionUpdate(int id, JsonPatchDocument<OrganizacionUpdateDto> patchDoc)
        {
            var organizacionModelFromRepo = _repository.GetOrganizacionById(id);
            if (organizacionModelFromRepo == null)
            {
                return NotFound();
            }

            var organizacionToPatch = _mapper.Map<OrganizacionUpdateDto>(organizacionModelFromRepo);
            patchDoc.ApplyTo(organizacionToPatch, ModelState);

            if(!TryValidateModel(organizacionToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(organizacionToPatch, organizacionModelFromRepo);

            _repository.UpdateOrganizacion(organizacionModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/organizaciones/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteOrganizacion(int id)
        {
            var organizacionModelFromRepo = _repository.GetOrganizacionById(id);
            if (organizacionModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeleteOrganizacion(organizacionModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

    }
}
