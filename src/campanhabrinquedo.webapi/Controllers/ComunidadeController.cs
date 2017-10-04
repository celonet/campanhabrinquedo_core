using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class ComunidadeController : Controller
    {
        private readonly IComunidadeService _service;

        public ComunidadeController(IComunidadeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var comunidades = _service.ListaComunidades();
            if (comunidades.Count > 0)
                return new ObjectResult(comunidades);
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var comunidade = _service.RetornaComunidadePorId(id);
            if (comunidade != null)
                return new ObjectResult(comunidade);
            return NotFound();
        }

        [HttpPost]
        public IActionResult Post([FromBody]Comunidade comunidade)
        {
            if (_service.InsereComunidade(comunidade))
                return Ok();
            return BadRequest("Comunidade já existe!");
        }

        [HttpPut]
        public IActionResult Put([FromBody]Comunidade comunidade)
        {
            return _service.AlteraComunidade(comunidade) ? Ok() : StatusCode(500);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.DeletaComunidade(id);
            return Ok();
        }
    }
}