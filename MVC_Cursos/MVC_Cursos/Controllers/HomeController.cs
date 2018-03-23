using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Models;
using MVC_Cursos.Services;

namespace MVC_Cursos.Controllers
{
    public class HomeController : Controller
    {
        private ITraineeData _traineeData;

        public HomeController(ITraineeData traineeData)
        {
            _traineeData = traineeData;
        }


        public IActionResult Index()
        {
            var model = _traineeData.GetAllTrainees();            
           
            return View(model);
        }
    }
}
