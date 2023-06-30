using Microsoft.AspNetCore.Mvc;

namespace AulasAspNetMVC.Controllers
{
    public class FilmesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Filmes";
            return View();
            // return "Essa é minha action padrdão vindo da Controllers";
        }
        public IActionResult BenVindoo(string nome, int numero) {
           return View( );
        }
    }
}
