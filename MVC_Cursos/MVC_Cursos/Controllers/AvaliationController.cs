using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Services.AvaliationServices;

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
            var model = _avaliatons.GetAllAvaliations();
            return View(model);
        }
    }
}
