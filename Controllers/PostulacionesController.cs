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
    [Route("api/postulaciones")]
    [ApiController]
    public class PostulacionesController : ControllerBase
    {
        private readonly IVoluntarioAPIRepo _repository;
        private readonly IMapper _mapper;

        public PostulacionesController(IVoluntarioAPIRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //GET api/postulaciones
        [HttpGet]
        public ActionResult<IEnumerable<PostulacionReadDto>> GetAllPostulaciones()
        {
            var postulacionItems = _repository.GetAllPostulaciones();

            return Ok(_mapper.Map<IEnumerable<PostulacionReadDto>>(postulacionItems));
        }

        //GET api/postulaciones/oportunidad/{id}
        [HttpGet("oportunidad/{id}", Name = "GetPostulacionesByOportunidadId")]
        public ActionResult<IEnumerable<PostulacionReadDto>> GetPostulacionesByOportunidadId(int id)
        {
            var postulacionItems = _repository.GetPostulacionesByOportunidadId(id);

            return Ok(_mapper.Map<IEnumerable<PostulacionReadDto>>(postulacionItems));
        }

        //GET api/postulaciones/voluntario/{id}
        [HttpGet("voluntario/{id}", Name = "GetPostulacionesByVoluntarioId")]
        public ActionResult<IEnumerable<PostulacionReadDto>> GetPostulacionesByVoluntarioId(int id)
        {
            var postulacionItems = _repository.GetPostulacionesByVoluntarioId(id);

            return Ok(_mapper.Map<IEnumerable<PostulacionReadDto>>(postulacionItems));
        }

        //GET api/postulaciones/{id}
        [HttpGet("{id}", Name = "GetPostulacionById")]
        public ActionResult<PostulacionReadDto> GetPostulacionById(int id)
        {
            var postulacionItem = _repository.GetPostulacionById(id);

            if (postulacionItem != null)
            {
                return Ok(_mapper.Map<PostulacionReadDto>(postulacionItem));
            }
            return NotFound();
        }

        //POST api/postulaciones
        [HttpPost]
        public ActionResult<PostulacionReadDto> CreatePostulacion(PostulacionCreateDto postulacionCreateDto)
        {
            var postulacionModel = _mapper.Map<Postulacion>(postulacionCreateDto);
            _repository.CreatePostulacion(postulacionModel);
            _repository.SaveChanges();

            var postulacionReadDto = _mapper.Map<PostulacionReadDto>(postulacionModel);

            return CreatedAtRoute(nameof(GetPostulacionById), new { Id = postulacionReadDto.PostulacionID }, postulacionReadDto);
        }

        //PUT api/postulaciones/{id}
        [HttpPut("{id}")]
        public ActionResult UpdatePostulacion(int id, PostulacionUpdateDto postulacionUpdateDto)
        {
            var postulacionModelFromRepo = _repository.GetPostulacionById(id);
            if (postulacionModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(postulacionUpdateDto, postulacionModelFromRepo);

            _repository.UpdatePostulacion(postulacionModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //PATCH api/postulaciones/{id}
        [HttpPatch("{id}")]
        public ActionResult PartialPostulacionUpdate(int id, JsonPatchDocument<PostulacionUpdateDto> patchDoc)
        {
            var postulacionModelFromRepo = _repository.GetPostulacionById(id);
            if (postulacionModelFromRepo == null)
            {
                return NotFound();
            }

            var postulacionToPatch = _mapper.Map<PostulacionUpdateDto>(postulacionModelFromRepo);
            patchDoc.ApplyTo(postulacionToPatch, ModelState);

            if (!TryValidateModel(postulacionToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(postulacionToPatch, postulacionModelFromRepo);

            _repository.UpdatePostulacion(postulacionModelFromRepo);

            _repository.SaveChanges();

            return NoContent();
        }

        //DELETE api/postulaciones/{id}
        [HttpDelete("{id}")]
        public ActionResult DeletePostulacion(int id)
        {
            var postulacionModelFromRepo = _repository.GetPostulacionById(id);
            if (postulacionModelFromRepo == null)
            {
                return NotFound();
            }

            _repository.DeletePostulacion(postulacionModelFromRepo);

            _repository.SaveChanges();

            return NoContent();

        }

    }
}
