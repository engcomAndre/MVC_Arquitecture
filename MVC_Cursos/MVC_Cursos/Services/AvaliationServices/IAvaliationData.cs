using MVC_Cursos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Cursos.Services.AvaliationServices
{
    public interface IAvaliationData
    {
        IEnumerable<Avaliation> GetAllAvaliations();
        Avaliation GetAvaliationsById(int id);
    }
}
