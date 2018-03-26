using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Models;
using MVC_Cursos.Services.AutorServices;
using MVC_Cursos.ViewModels.AutorViewModel;

namespace MVC_Cursos.Controllers
{
    public class AutorController : Controller
    {
        private IAutorData _autorsData;

        public AutorController(IAutorData autorData)
        {
            _autorsData = autorData;
        }
        public IActionResult Index()
        {
            var model = new AutorIndexViewModel();
            model.Autors = _autorsData.GetAllAutors();
            model.AutorCurrentMessage = "Autor Current Message";
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _autorsData.GetAutorById(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(AutorEditModel autor)
        {
            var newAutor = new Autor();
            newAutor.Name = autor.Name;

            newAutor = _autorsData.Add(newAutor);

            return View(nameof(Details),newAutor);

        }
    }
}








