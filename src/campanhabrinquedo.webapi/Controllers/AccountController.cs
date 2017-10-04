using Microsoft.AspNetCore.Mvc;
using campanhabrinquedo.domain.Entities;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[Controller]")]
    public class  AccountController : Controller
    {
        private IUsuarioService _service;

        public AccountController(IUsuarioService service)
        {
            _service = service;
        }

        public IActionResult Post([FromBody]Usuario comunidade)
        {
            return NotFound();
        }
    }
}