using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using campanhabrinquedo.domain.Services;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class CampanhaController : Controller
    {
        private ICampanhaService _service;

        public CampanhaController(ICampanhaService service)
        {
            _service = service;
        }
    }
}