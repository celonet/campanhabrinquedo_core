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
    public class CriancaController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICriancaService _service;

        public CriancaController(IMapper mapper, ICriancaService service)
        {
            _service = service;
            _mapper = mapper;
        }

         [HttpGet]
        public IActionResult Get()
        {
            var crianca = _service.Lista();
            if (!crianca.Any()) return NotFound();
            var criancaViewModel = crianca.ProjectTo<CriancaViewModel>();
            return new ObjectResult(criancaViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var crianca = _service.RetornaPorId(id);
            if (crianca != null)
                return new ObjectResult(_mapper.Map<CriancaViewModel>(crianca));
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]CriancaViewModel criancaViewModel)
        {
            var crianca = _mapper.Map<Crianca>(criancaViewModel);
            _service.Insere(crianca);
            return Created("", criancaViewModel);
        }

        [HttpPut]
        public IActionResult Put([FromBody]CriancaViewModel CriancaViewModel)
        {
            var crianca = _mapper.Map<Crianca>(CriancaViewModel);
            _service.Altera(crianca);
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