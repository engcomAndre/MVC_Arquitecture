using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Models;

namespace MVC_Cursos.ViewModels.CourseViewModel
{
    public class CourseIndexViewModel
    {
        public IEnumerable<Course> Courses;
        public string CourseCurrentMessage;
    }
}
