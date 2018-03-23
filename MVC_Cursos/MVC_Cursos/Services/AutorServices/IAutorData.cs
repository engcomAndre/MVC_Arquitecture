using MVC_Cursos.Models;
using System.Collections.Generic;

namespace MVC_Cursos.Services.AutorServices
{
    public interface IAutorData
    {
        IEnumerable<Autor> GetAllAutors();
    }
}