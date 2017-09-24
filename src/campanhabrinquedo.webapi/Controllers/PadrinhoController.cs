using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class PadrinhoController : Controller
    {
        private IPadrinhoService _service;

        public PadrinhoController(IPadrinhoService service)
        {
            _service = service;
        }
    }
}