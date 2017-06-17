using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    public class CriancaController : Controller
    {
        private ICriancaService _service;

        public CriancaController(ICriancaService service)
        {
            _service = service;
        }
    }
}