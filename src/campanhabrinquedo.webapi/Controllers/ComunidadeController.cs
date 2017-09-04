using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    public class ComunidadeController : Controller
    {
        private IComunidadeService _service;

        public ComunidadeController(IComunidadeService service)
        {
            _service = service;
        }
    }
}