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
    public class CampanhaController : Controller
    {
        private readonly IMapper _mapper;

        private ICampanhaService _service;

        public CampanhaController(IMapper mapper, ICampanhaService service)
        {
            _service = service;
            _mapper = mapper;
        }

         [HttpGet]
        public IActionResult Get()
        {
            var campanhas = _service.Lista();
            if (!campanhas.Any()) return NotFound();
            var campanhasViewModel = campanhas.ProjectTo<CampanhaViewModel>();
            return new ObjectResult(campanhasViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var campanha = _service.RetornaPorId(id);
            if (campanha != null)
                return new ObjectResult(_mapper.Map<CampanhaViewModel>(campanha));
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]CampanhaViewModel campanhaViewModel)
        {
            var campanha = _mapper.Map<Campanha>(campanhaViewModel);
            _service.Insere(campanha);
            return Created("", campanhaViewModel);
        }

        [HttpPut]
        public IActionResult Put([FromBody]CampanhaViewModel campanhaViewModel)
        {
            var campanha = _mapper.Map<Campanha>(campanhaViewModel);
            _service.Altera(campanha);
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