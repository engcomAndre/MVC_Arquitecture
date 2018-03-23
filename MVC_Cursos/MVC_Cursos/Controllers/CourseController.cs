using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Services.CourseServices;

namespace MVC_Cursos.Controllers
{
    public class CourseController : Controller
    {
        private ICourseData _courseData;

        public CourseController(ICourseData courseData)
        {
            _courseData = courseData;
        }
        public IActionResult Index()
        {
            var model = _courseData.GetAllCourses();
            return View(model);
        }
    }
}
