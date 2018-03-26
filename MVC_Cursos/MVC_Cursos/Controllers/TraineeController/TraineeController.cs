using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Services;
using MVC_Cursos.Models;
using MVC_Cursos.ViewModels.TraineeViewModel;

namespace MVC_Cursos.Controllers
{
    public class TraineeController : Controller
    {
        private ITraineeData _traineeData;

        public TraineeController(ITraineeData traineeData)
        {
            _traineeData = traineeData;
        }

        public IActionResult Index()
        {
            var model = new TraineeIndexViewModel();
            model.Trainees = _traineeData.GetAllTrainees();
            model.TraineeCurrenMessage = "Trainees Current Message";
            return View(model);
        }

        public IActionResult Details(int id)
        {
            //atributions            
            var model = _traineeData.GetTraineeForId(id);                         
            
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
        public IActionResult Create(TraineeEditModel Trainee)
        {
            var newTrainee = new Trainee();
            newTrainee.Name = Trainee.Name;

           newTrainee =  _traineeData.Add(newTrainee);

            return View(nameof(Details), newTrainee);

        }
    }
}















