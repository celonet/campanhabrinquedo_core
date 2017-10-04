using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.domain.Validators;
using Microsoft.AspNetCore.Mvc;
using System;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class ComunidadeController : Controller
    {
        private IComunidadeService _service;
        private ComunidadeValidator _validator;

        public ComunidadeController(IComunidadeService service)
        {
            _service = service;
            _validator = new ComunidadeValidator();
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
            var result = _validator.Validate(comunidade);
            if (result.IsValid)
            {
                if (_service.InsereComunidade(comunidade))
                    return Ok();
                return BadRequest("Comunidade já existe!");
            }
            return BadRequest(result.Errors);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Comunidade comunidade)
        {
            var result = _validator.Validate(comunidade);
            if (result.IsValid)
            {
                _service.AlteraComunidade(comunidade);
                return Ok();
            }
            return StatusCode(500);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.DeletaComunidade(id);
            return Ok();
        }
    }
}