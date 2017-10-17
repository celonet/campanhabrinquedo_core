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
    public class PadrinhoController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPadrinhoService _service;

        public PadrinhoController(IMapper mapper, IPadrinhoService service)
        {
            _service = service;
            _mapper = mapper;
        }

         [HttpGet]
        public IActionResult Get()
        {
            var padrinho = _service.Lista();
            if (!padrinho.Any()) return NotFound();
            var PadrinhoViewModel = padrinho.ProjectTo<PadrinhoViewModel>();
            return new ObjectResult(PadrinhoViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var padrinho = _service.RetornaPorId(id);
            if (padrinho != null)
                return new ObjectResult(_mapper.Map<PadrinhoViewModel>(padrinho));
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]PadrinhoViewModel PadrinhoViewModel)
        {
            var padrinho = _mapper.Map<Padrinho>(PadrinhoViewModel);
            _service.Insere(padrinho);
            return Created("", PadrinhoViewModel);
        }

        [HttpPut]
        public IActionResult Put([FromBody]PadrinhoViewModel PadrinhoViewModel)
        {
            var padrinho = _mapper.Map<Padrinho>(PadrinhoViewModel);
            _service.Altera(padrinho);
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