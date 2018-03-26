using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Services.CourseServices
{
    public interface ICourseData
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        Course Add(Course Course);
    }
}
