using System;
using System.Collections.Generic;
using System.Linq;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Repositorio;
using campanhabrinquedo.repositorio;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller 
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]        
        public IEnumerable<Usuario> Get()
        {
            return _usuarioRepositorio.ListaUsuarios();
        }

        [HttpGet("{id}")]
        public Usuario Get(Guid id)
        {
            return _usuarioRepositorio.BuscaUsuario(id);
        }

        [HttpPost]
        public void Post([FromBody]Usuario usuario)
        {
            _usuarioRepositorio.RegistraUsuario(usuario);
        }

        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]Usuario usuario)
        {
            _usuarioRepositorio.AlteraUsuario(usuario);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _usuarioRepositorio.DeletaUsuario(id);
        }
    }    
}
