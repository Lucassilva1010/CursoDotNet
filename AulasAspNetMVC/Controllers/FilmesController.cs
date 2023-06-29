using Microsoft.AspNetCore.Mvc;

namespace AulasAspNetMVC.Controllers
{
    public class FilmesController : Controller
    {
        public string Index()
        {
            return "Essa é minha action padrdão vindo da Controllers";
        }
        public string Benvindo(string nome, int numero) => $"Criando a minhas propria Actions {nome} - {numero} ";
    }
}
