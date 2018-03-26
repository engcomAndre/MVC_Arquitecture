using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_Cursos.Models;

namespace MVC_Cursos.Services.CourseServices
{
    public class InMemoryCourseData : ICourseData
    {
        private List<Course> _courses;

        public InMemoryCourseData()
        {
            _courses = new List<Course>
            {
                new Course  {id = 1,Title = "Title Course 1",idAutor=1,TecnologyCourse = TecnologyType.Algorithms},
                new Course  {id = 2,Title = "Title Course 2",idAutor=2,TecnologyCourse = TecnologyType.BackEnd},
                new Course  {id = 3,Title = "Title Course 3",idAutor=3,TecnologyCourse = TecnologyType.DevelopmentCsharp},
                new Course  {id = 4,Title = "Title Course 4",idAutor=4,TecnologyCourse = TecnologyType.FrontEnd},
                new Course  {id = 5,Title = "Title Course 5",idAutor=5,TecnologyCourse = TecnologyType.Html}
            };
        }

        public Course Add(Course Course)
        {
            Course.id = _courses.Max(course => course.id) + 1;

            _courses.Add(Course);

            return Course;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courses.OrderBy(course => course.id);
        }

        public Course GetCourseById(int id)
        {
            return _courses.FirstOrDefault(course => course.id == id);
        }
    }
}
