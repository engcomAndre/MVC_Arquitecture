using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Services;

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
            var model = _traineeData.GetAllTrainees();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model =  _traineeData.GetForId(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
