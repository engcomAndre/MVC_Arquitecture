using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.ViewModels.TraineeViewModel
{
    public class TraineeIndexViewModel
    {
        public IEnumerable<Trainee> Trainees;
        public string TraineeCurrenMessage { get; set; }
    }
}
