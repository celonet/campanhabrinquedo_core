using campanhabrinquedo.domain.Entidades;
using campanhabrinquedo.domain.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace campanhabrinquedo.webapi.Controllers
{
    public class ComunidadeController : Controller
    {
        private IComunidadeService _service;

        public ComunidadeController(IComunidadeService service)
        {
            _service = service;
        }

        public List<Comunidade> Get()
        {
            return _service.ListaComunidades();
        }
    }
}