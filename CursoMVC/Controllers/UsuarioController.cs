using CursoMVC.Models;
using System.Collections.ObjectModel;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class UsuarioController : Controller
    {

        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);

            }

            return View(usuario);


        }

        
        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }
    }
}