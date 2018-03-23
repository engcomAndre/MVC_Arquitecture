using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Services.AutorServices;

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
            var model = _autorsData.GetAllAutors();
            return View(model);
        }
    }
}
