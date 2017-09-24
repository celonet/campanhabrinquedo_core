using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class CriancaController : Controller
    {
        private ICriancaService _service;

        public CriancaController(ICriancaService service)
        {
            _service = service;
        }
    }
}