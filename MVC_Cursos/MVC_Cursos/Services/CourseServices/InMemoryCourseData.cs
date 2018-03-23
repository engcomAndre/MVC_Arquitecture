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
                new Course  {id = 1,Title = "Title Course 1"},
                new Course  {id = 2,Title = "Title Course 2"},
                new Course  {id = 3,Title = "Title Course 3"},
                new Course  {id = 4,Title = "Title Course 4"},
                new Course  {id = 5,Title = "Title Course 5"}
            };
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courses.OrderBy(course => course.id);

        }
    }
}
