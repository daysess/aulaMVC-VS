using CursoMVC.Models;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class HomeController : Controller
    { 

        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Dayse Soares",
                Tipo = "Administrador"
            };

            return View(pessoa);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa)
        {
            return View(pessoa);
        }

    }
}