using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class ComunidadeController : Controller
    {
        private IComunidadeService _service;

        public ComunidadeController(IComunidadeService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var comunidades = _service.ListaComunidades();
            if(comunidades.Count > 0)
                return new ObjectResult(comunidades);            
            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var comunidade = _service.RetornaComunidadePorId(id);
            if(comunidade != null)
                return new ObjectResult(comunidade);
            
            return NotFound();
        }
    }
}