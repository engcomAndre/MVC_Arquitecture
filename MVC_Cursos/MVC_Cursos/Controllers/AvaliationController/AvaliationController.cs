using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Services.AvaliationServices;
using MVC_Cursos.ViewModels.AvaliationViewModel;

namespace MVC_Cursos.Controllers
{
    public class AvaliationController : Controller
    {
        private IAvaliationData _avaliatons;

        public AvaliationController(IAvaliationData avaliaton)
        {
            _avaliatons = avaliaton;
        }
        public IActionResult Index()
        {
            var model = new AvaliationIndexViewModel();
            model.AvaliationCurrentMessage = "Avaliation Current Message";
            model.Avaliations = _avaliatons.GetAllAvaliations();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _avaliatons.GetAvaliationsById(id);

            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
