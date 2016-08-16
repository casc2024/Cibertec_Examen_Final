using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;

namespace WebDeveloper.Areas.Autor.Controllers
{
    [Authorize]  
    public class AutorController : Controller
    {
        private readonly RepositorioAutor _repositorioAutor;
        public AutorController(RepositorioAutor repositorioAutor)
        {
            _repositorioAutor = repositorioAutor;

        }

        // GET: Autor/Autor
        public ActionResult Index()
        {
            ViewBag.TotalPaginas = TotalPaginas(10);
            return View();
        }

        [OutputCache(Duration = 0)]
        public ActionResult Listar(int? pagina, int? tamanio)
        {
            if (!pagina.HasValue || !tamanio.HasValue)
            {
                pagina = 1;
                tamanio = 10;
            }           
            return View(_repositorioAutor.ListaAutorDTO().Page(pagina.Value, tamanio.Value));
        }
        [OutputCache(Duration = 0)]
        public ActionResult Editar(int id) {
            var _autor = _repositorioAutor.ObtenerAutorId(id);
            if (_autor == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Editar", _autor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]
        [OutputCache(Duration = 0)]
        public ActionResult Editar(WebDeveloper.Model.Autor autor)
        {
            if (!ModelState.IsValid) return PartialView("_Editar", autor);
            _repositorioAutor.Actualizar(autor);
            return RedirectToRoute("Autor_default");
        }
        public ActionResult Detalles(int id) {
            var _autor = _repositorioAutor.ObtenerAutorId(id);
            if (_autor == null) return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            return PartialView("_Detalles", _autor);
        }
       

        public ActionResult Crear() {
            return PartialView("_Crear");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(WebDeveloper.Model.Autor autor)
        {
            if (!ModelState.IsValid) return PartialView("_Create", autor);
            _repositorioAutor.Agregar(autor);            
            return new HttpStatusCodeResult(HttpStatusCode.OK); 
        }

        #region TotalPaginas
        public int TotalPaginas(int? tamaño)
        {
            if (!tamaño.HasValue) tamaño = 10;
            var filas = _repositorioAutor.Contar();
            return filas / tamaño.Value;
        }
        #endregion
    }
}