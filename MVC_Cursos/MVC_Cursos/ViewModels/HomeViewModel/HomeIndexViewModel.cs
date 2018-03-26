using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Trainee> Trainees{ get; set; }
        public string CurrentMessage{ get; set; }
    }
}
