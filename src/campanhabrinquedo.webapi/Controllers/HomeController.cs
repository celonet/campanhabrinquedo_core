using Microsoft.AspNetCore.Mvc;

namespace campanhabrinquedo.webapi.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        public string Get(){
            return "Bem vindo a Campanha do Brinquedo API";
        }
    }
}