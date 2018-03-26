using Microsoft.AspNetCore.Mvc; 
using MVC_Cursos.Models;
using MVC_Cursos.Services;
using MVC_Cursos.ViewModels;
using MVC_Cursos.ViewModels.HomeViewModel;

namespace MVC_Cursos.Controllers
{
    public class HomeController : Controller
    {
        private ITraineeData _traineeData;
        private IGreeter _greeter;

        public HomeController(ITraineeData traineeData,IGreeter greeter)
        {
            _traineeData = traineeData;
            _greeter = greeter;
        }


        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.Trainees = _traineeData.GetAllTrainees();
            model.CurrentMessage = _greeter.GetMessageOfDay();           
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _traineeData.GetTraineeForId(id);
            if(model == null)
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
        public IActionResult Create(HomeEditModel model)
        {
            var newTrainee = new Trainee();
            newTrainee.Name = model.Name;

            newTrainee = _traineeData.Add(newTrainee);                       

            return View(nameof(Details),newTrainee);
        }
        
    }
}
