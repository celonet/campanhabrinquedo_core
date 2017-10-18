using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using campanhabrinquedo.Application.ViewModel;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Services;
using campanhabrinquedo.webapi.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _service;
        private readonly TokenProviderOptions _options;
        private readonly IMapper _mapper;

        public UsuarioController(IMapper mapper, IUsuarioService service)
        {
            _service = service;
            _options = new TokenProviderOptions();
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var usuario = _service.RetornaPorId(id);
            if (usuario != null)
                return new ObjectResult(usuario);

            return NotFound();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post([FromBody]UsuarioViewModel usuarioViewModel)
        {
            var usuario = _mapper.Map<Usuario>(usuarioViewModel);
            if (_service.Existe(usuario))
                return BadRequest("Usuario já existe");

            _service.Insere(usuario);

            return Created("Usuario", usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody]UsuarioViewModel usuarioViewModel)
        {
            var usuario = _mapper.Map<Usuario>(usuarioViewModel);
            _service.Altera(usuario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _service.Deleta(id);
            return Ok();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("token")]
        public async Task<IActionResult> GenerateToken([FromBody] LoginViewModel model)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var secretKey = config["JwtIssuerOptions:SecretKey"];

            if (!ModelState.IsValid)
                return BadRequest(model);

            var result = await _service.LogarUsuario(model.Usuario, model.Senha);

            if (!result) return BadRequest("Invalid username or password");

            var now = DateTime.UtcNow;

            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));

            var jwt = new JwtSecurityToken(
                config["JwtIssuerOptions:Issuer"],
                config["JwtIssuerOptions:Audience"],
                notBefore: now,
                expires: now.Add(_options.Expiration),
                signingCredentials: new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256));

            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            return Ok(new
            {
                access_token = encodedJwt,
                expires_in = (int)_options.Expiration.TotalSeconds
            });
        }
    }
}

