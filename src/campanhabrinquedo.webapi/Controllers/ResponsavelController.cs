using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.Application.ViewModel;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class ResponsavelController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IResponsavelService _service ;

        public ResponsavelController(IMapper mapper, IResponsavelService service)
        {
            _service = service;
            _mapper = mapper;
        }

          [HttpGet]
        public IActionResult Get()
        {
            var responsavel = _service.Lista();
            if (!responsavel.Any()) return NotFound();
            var responsavelViewModel = responsavel.ProjectTo<ResponsavelViewModel>();
            return new ObjectResult(responsavelViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var responsavel = _service.RetornaPorId(id);
            if (responsavel != null)
                return new ObjectResult(_mapper.Map<ResponsavelViewModel>(responsavel));
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]ResponsavelViewModel responsavelViewModel)
        {
            var responsavel = _mapper.Map<Responsavel>(responsavelViewModel);
            if(_service.Insere(responsavel) != null)
                return BadRequest(responsavelViewModel);
            return Created("", responsavelViewModel);
        }

        [HttpPut]
        public IActionResult Put([FromBody]ResponsavelViewModel responsavelViewModel)
        {
            var responsavel = _mapper.Map<Responsavel>(responsavelViewModel);
            if(_service.Altera(responsavel) != null)
                return BadRequest(responsavelViewModel);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Deleta(id);
            return Ok();
        }
    }
}