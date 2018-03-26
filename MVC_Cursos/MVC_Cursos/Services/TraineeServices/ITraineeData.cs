using Microsoft.AspNetCore.Mvc;
using MVC_Cursos.Models;
using System.Collections.Generic;

namespace MVC_Cursos.Services
{
    public interface ITraineeData
    {
        IEnumerable<Trainee> GetAllTrainees();
        Trainee GetTraineeForId(int id);
        Trainee Add(Trainee newTrainee);
    }
}
