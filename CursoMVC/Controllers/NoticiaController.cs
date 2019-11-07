using CursoMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class NoticiaController : Controller
    {


        private readonly IEnumerable<Noticia> todasAsNoticias;

        public NoticiaController()
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data);
        }


        // GET: Noticia
        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasAsCategorias;
            return View(ultimasNoticias);
        }

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
        {

            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();
            ViewBag.Categoria = categoria;

            return View(categoriaEspecifica);

        }
    }
}