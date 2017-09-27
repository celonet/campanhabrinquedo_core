using System;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuarioController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var usuario = _service.RetornaPerfil(id);
            if(usuario != null)
                return new ObjectResult(usuario);
            
            return NotFound();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody]Usuario usuario)
        {
            if (_service.UsuarioExiste(usuario))
                return BadRequest("Usuario já existe");
            
            _service.RegistraUsuario(usuario);
            
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]Usuario usuario)
        {
            _service.AlteraUsuario(usuario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.DeletaUsuario(id);
            return Ok();
        }
    }
}
