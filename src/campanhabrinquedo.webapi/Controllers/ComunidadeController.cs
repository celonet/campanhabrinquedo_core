using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using campanhabrinquedo.Application.ViewModel;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class ComunidadeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IComunidadeService _service;

        public ComunidadeController(IMapper mapper, IComunidadeService service)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var comunidades = _service.Lista();
            if (!comunidades.Any()) return NotFound();
            var comunidadesViewModel = comunidades.ProjectTo<ComunidadeViewModel>();
            return new ObjectResult(comunidadesViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var comunidade = _service.RetornaPorId(id);
            if (comunidade != null)
                return new ObjectResult(_mapper.Map<ComunidadeViewModel>(comunidade));
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]ComunidadeViewModel comunidadeViewModel)
        {
            var comunidade = _mapper.Map<Comunidade>(comunidadeViewModel);
            _service.Insere(comunidade);
            return Created("", comunidadeViewModel);
        }

        [HttpPut]
        public IActionResult Put([FromBody]ComunidadeViewModel comunidadeViewModel)
        {
            var comunidade = _mapper.Map<Comunidade>(comunidadeViewModel);
            _service.Altera(comunidade);
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