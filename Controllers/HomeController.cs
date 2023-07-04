using DominandoAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DominandoAspNetCore.Controllers
{
    //quando especificamos que pode vir vazio não podemos deixar mais nenhuma controller vir assim se não
    //o sistema não vai entender qual acessar isso tambem serve para os métodos abaixo.
    [Route("")]  
    [Route("teste-aplicacao")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")] //não podemos ter mais nenhuma chamada assim ou sem nada de ROUTE se não o sistema não vai saber identificar
        [Route("iniciando-aplicacao")]
        [Route("iniciando-aplicacao/{id:int}/{teste:int}")]
        public IActionResult Index(int id,int teste)
        {
            return View();
        }

        [Route("privacidade-aplicacao")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-aplicacao")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}