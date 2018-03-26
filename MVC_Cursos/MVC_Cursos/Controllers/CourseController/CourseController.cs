using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Models;
using MVC_Cursos.Services.AutorServices;
using MVC_Cursos.Services.CourseServices;
using MVC_Cursos.ViewModels.CourseViewModel;

namespace MVC_Cursos.Controllers
{
    public class CourseController : Controller
    {
        private ICourseData _courseData;
        private IAutorData _autorData;

        public CourseController(ICourseData courseData,IAutorData autorData)
        {
            _courseData = courseData;
            _autorData = autorData;
        }
        public IActionResult Index()
        {
            var model = new CourseIndexViewModel();
            model.Courses = _courseData.GetAllCourses();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var Course = _courseData.GetCourseById(id);
            var model = new CourseDetailsModel();
            model.Course = _courseData.GetCourseById(id);
            model.AutorName = _autorData.GetAutorById(model.Course.idAutor).Name;

            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var model = new CourseEditModel();
            model.Autors = _autorData.GetAllAutors();
            
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(CourseEditModel model)
        {
            var newCourse = new Course();
            newCourse.Title = model.Title;
            newCourse.TecnologyCourse = model.Tecnology;
            newCourse.idAutor = _autorData.GetAutorByName(model.AutorName).id;            
            newCourse = _courseData.Add(newCourse);

            return View(nameof(Details),newCourse);
        }
        
    }
}









