using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    public class ResponsavelController : Controller
    {
        private IResponsavelService _service ;

        public ResponsavelController(IResponsavelService service)
        {
            _service = service;
        }
    }
}