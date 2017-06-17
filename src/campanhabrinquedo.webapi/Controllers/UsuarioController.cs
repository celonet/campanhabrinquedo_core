using System;
using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.repositorio;
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
        public Usuario Get(Guid id)
        {
            return _service.RetornaPerfil(id);
        }

        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
            _service.RegistraUsuario(usuario);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Usuario usuario)
        {
            _service.AlteraUsuario(usuario);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _service.DeletaUsuario(id);
        }
    }    
}
