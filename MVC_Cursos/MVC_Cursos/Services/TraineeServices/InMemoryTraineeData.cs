using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Services
{
    public class InMemoryTraineeData :ITraineeData
    {
        private List<Trainee> _trainees;

        public InMemoryTraineeData()
        {
            _trainees = new List<Trainee> {
            new Trainee { id = 1, Name = "Trainee 1" },
            new Trainee { id = 2, Name = "Trainee 2" },
            new Trainee { id = 3, Name = "Trainee 3" },
            new Trainee { id = 4, Name = "Trainee 4" },
            new Trainee { id = 5, Name = "Trainee 5" }
            };
        }

        public Trainee Add(Trainee newTrainee)
        {
            newTrainee.id = _trainees.Max(trainee => trainee.id) + 1;
            _trainees.Add(newTrainee);
            return newTrainee;           
        }

        public IEnumerable<Trainee> GetAllTrainees()
        {
            return _trainees.OrderBy(trainee => trainee.id);        
        }

        public Trainee GetTraineeForId(int id)
        {
            return _trainees.FirstOrDefault(trainee => trainee.id == id);
        }
    }
}
