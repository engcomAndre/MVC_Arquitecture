using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.ViewModels.CourseViewModel
{
    public class CourseDetailsModel
    {
        public Course Course;
        public string AutorName{ get; set; }
    }
}
